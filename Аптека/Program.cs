using static System.Console;

namespace ClassProject
{
    class Program
    {
        public static void Main()
        {
            Apteka apt1 = new Apteka { name = "Apteka.ru" };
            ShowName(apt1.name);
            apt1.Add(new Medicines { name = "Мукалтин", price = 80f });
            apt1.Add(new Medicines { name = "Нурофен", price = 500f });
            apt1.Add(new Medicines { name = "Анальгин", price = 100f });
            apt1.Add(new Medicines { name = "Парацетамол", price = 150f });
            WriteLine("-----------------");
            apt1.ShowMeds();
            WriteLine("-----------------");
            apt1.DetectExpensiveMedicines();
            WriteLine("-----------------");
            apt1.GetSumPriceMedicines();
            ReadKey();
        }

        static void ShowName(string name)
        {
            WriteLine($"Название аптеки: {name}");
        }
    }
}