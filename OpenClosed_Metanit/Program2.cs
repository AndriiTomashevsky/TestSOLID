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

        public void MakeDinner(BaseMeal[] menu)
        {
            foreach (BaseMeal meal in menu)
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

        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalStep();

    }

    class PotatoMeal : BaseMeal
    {
        protected override void Cook()
        {
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        }

        protected override void FinalStep()
        {
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Чистим картошку");
        }
    }

    class SaladMeal : BaseMeal
    {
        protected override void Cook()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
        }

        protected override void FinalStep()
        {
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Моем помидоры и огурцы");
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            BaseMeal[] menu = new BaseMeal[] { new PotatoMeal(), new SaladMeal() };

            Cook bob = new Cook("Bob");
            bob.MakeDinner(menu);

            Console.ReadKey();
        }
    }
}
