using static System.Console;

namespace ClassProject
{
    class Program
    {
        public static void Main()
        {
            Apteka apt1 = new Apteka { name = "Apteka.ru" };
            ShowName(apt1.name);
            apt1.Add(new Medicine { name = "Мукалтин", price = 80f });
            apt1.Add(new Medicine { name = "Нурофен", price = 500f });
            apt1.Add(new Medicine { name = "Анальгин", price = 100f });
            apt1.Add(new Medicine { name = "Парацетамол", price = 150f });
            WriteLine("__________________________________");
            apt1.ShowMeds();
            WriteLine("__________________________________");
            apt1.DetectExpensiveMedicines();
            WriteLine("__________________________________");
            apt1.GetSumPriceMedicines();
            ReadKey();
        }

        static void ShowName(string name)
        {
            WriteLine($"Название аптеки: {name}");
        }
    }
}