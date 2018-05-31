using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Observer
{
   public class IBM : Stock
    {
        Random random = new Random();
        public void setPrice()
        {
            this.Price = random.Next(0, 200);
            Notify();
        }
    }
}
