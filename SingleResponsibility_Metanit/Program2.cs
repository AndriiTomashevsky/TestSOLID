using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Metanit
{
    internal interface IReader
    {
        string[] ReadData();
    }

    class Phone
    {
        public string Model { get; set; }
        public int Price { get; set; }
    }

    class MobileStore
    {
        List<Phone> phones = new List<Phone>();

        public MobileStore(IReader reader)
        {
            Reader = reader;
        }

        public IReader Reader { get; set; }
        public IBinder Binder { get; set; }
        public IValidator Validator { get; set; }
        public ISaver Saver { get; set; }

        public void Process()
        {
            string[] data = Reader.ReadData();
            Phone phone = Binder.Bind(data);

            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, "store.txt");
                Console.WriteLine("Данные успешно обработаны");
            }
            else
            {
                throw new Exception("Invalid data");
            }
        }
    }

    interface ISaver
    {
        void Save(Phone phone, string v);
    }

    interface IValidator
    {
        bool IsValid(Phone phone);
    }

    interface IBinder
    {
        Phone Bind(string[] data);
    }

    class Reader : IReader
    {
        public string[] ReadData()
        {
            Console.WriteLine("Введите модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            string price = Console.ReadLine();

            return new string[] { model, price };
        }
    }

    class Saver : ISaver
    {
        public void Save(Phone phone, string path)
        {
            // сохраняем данные в файл
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path, true))
            {
                writer.WriteLine(phone.Model);
                writer.WriteLine(phone.Price);
            }
        }
    }

    class Binder : IBinder
    {
        public Phone Bind(string[] data)
        {
            Phone phone = new Phone();

            if (data.Length >= 2)
            {
                if (Int32.TryParse(data[1], out int price))
                {
                    phone.Model = data[0];
                    phone.Price = price;
                }
                else
                {
                    throw new Exception("Can not parce price");
                }
            }
            else
            {
                throw new Exception("Incomplete Data");
            }
            return phone;
        }
    }

    class Validator : IValidator
    {
        public bool IsValid(Phone phone)
        {
            if (string.IsNullOrEmpty(phone.Model) || phone.Price <= 0)
            {
                return false;
            }
            return true;
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
