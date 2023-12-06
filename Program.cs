using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Inheritenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); //chef is trhe object name
            chef.MakeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakeChicken(); //Chef is superclass, ItalianChef is a subclass
            chef1.MakesPasta();
            chef1.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
