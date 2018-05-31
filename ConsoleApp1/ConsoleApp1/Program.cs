using ConsoleApp1.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

    class Program
    {
        
        static void Main(string[] args)
        {
           
            IBM ibm = new IBM();
           
            ibm.Attach(new Investor("Светлана Петровна"));
            ibm.Attach(new Investor("Юрий Павлович"));
            ibm.Attach(new Investor("Дмитрий Юрьевич"));
            ibm.Attach(new Investor("Никита Сергеевич"));
            ibm.Attach(new Investor("Юлиана Борисовна"));

            for (int i = 0; i < 10; i++)
            {          
                ibm.setPrice();
            }
        }
    }
    
}
