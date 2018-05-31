using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Observer
{
    public abstract class Stock
    {
        List<Investor> investors;
        string companyName;
        int price;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Stock()
        {
            investors = new List<Investor>();
        }

        public void Attach(Investor investor)
        {
            investors.Add(investor);
        }

        public void Notify()
        {
            foreach (Investor buf in investors)
            {
                buf.Update(this.price);
            }
        }

    }
}