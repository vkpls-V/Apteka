using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    public class Apteka
    {
        public string name { get; set;}
    List<Medicine> medicines;

    public Apteka()
    {
        medicines = new List<Medicine>();
    }
    public void Add(Medicine add_medicine)
    {
        medicines.Add(add_medicine);
    }

    public void DetectExpensiveMedicines()
    {
        float expensive = 0f;
        string expensive_name = "";
        foreach (var variable in medicines)
        {
            if (expensive < variable.price)
            {
                expensive = variable.price;
                expensive_name = variable.name;
            }
        }
        Console.WriteLine($"Самое дорогое лекарство: {expensive_name}, его цена: {expensive} руб.");
    }
    public void GetSumPriceMedicines()
    {
        float sum = 0f;
        foreach (var variable in medicines)
        {
            sum += variable.price;
        }
        Console.WriteLine($"Сумма стоимости всех лекарств: {sum} руб.");
    }
    public void ShowMeds()
    {
        foreach (var variable in medicines)
        {
            Console.WriteLine($"{variable.name}, цена: {variable.price} руб.");
        }
    }
}
    public class Medicine
    {
          public string name { get; set; }
public float price { get; set; } 
    }
}