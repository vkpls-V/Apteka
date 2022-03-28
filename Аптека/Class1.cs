using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    public class Apteka
    {
        publicstringname { get; set; }
    List<Medicines> >medicines;

        public Apteka()
    {
        medicines = new List<Medicines>();
    }
    public void Add(Medicines add_medicines)
    {
        medicines.Add(add_medicines);
    }

    public void DetectExpensiveMedicines()
    {
        float expensive = 0f;
        string expensive_name = "";
        foreach (varvariable in medicines)
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
        foreach (varvariable in medicines)
        {
            sum += variable.price;
        }
        Console.WriteLine($"Сумма стоимости всех лекарств: {sum} руб.");
    }
    public void ShowMeds()
    {
        foreach (varvariable in medicines)
        {
            Console.WriteLine($"{variable.name}, цена: {variable.price} руб.");
        }
    }
}
public classMedicines
    {
    publicstringname { get; set; }
        public float price { get; set; } 
    }
}