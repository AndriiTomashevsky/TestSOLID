using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Template Method
namespace OpenClosed_Metanit2
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(BaseMeal meal)
        {
            meal.Make();
        }
    }

    abstract class BaseMeal
    {
        public void Make()
        {
            Prepare();
            Cook();
            FinalStep();
        }

        public abstract void Prepare();
        public abstract void Cook();
        public abstract void FinalStep();

    }

    class PotatoMeal : BaseMeal
    {
        public override void Cook()
        {
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        }

        public override void FinalStep()
        {
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }

        public override void Prepare()
        {
            Console.WriteLine("Чистим картошку");
        }
    }

    class SaladMeal : BaseMeal
    {
        public override void Cook()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
        }

        public override void FinalStep()
        {
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }

        public override void Prepare()
        {
            Console.WriteLine("Моем помидоры и огурцы");
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Cook bob = new Cook("Bob");
            bob.MakeDinner(new PotatoMeal());
            bob.MakeDinner(new SaladMeal());

            Console.ReadKey();
        }
    }
}
