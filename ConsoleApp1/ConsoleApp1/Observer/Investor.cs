using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.Observer
{
    public class Investor : iInvestor
    {
        string Name;
        int Price;

        public Investor(string Name)
        {
            this.Name = Name;
        }
        public void Update(int Price)
        {
            this.Price = Price;
            Display();
        }

        public void Display()
        {
            
            WriteLine($"{Name}: Получены новые значения  [${Price}]");
            if (Price > 100)
            {
                WriteLine("Рекомендация: акции следует продавать!");
            }
            else
            {
                WriteLine("Рекомендация: акции следует покупать!");
            }
            WriteLine("--------------------------------------------");
        }
    }
}
