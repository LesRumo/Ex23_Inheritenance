using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Inheritenance
{
    internal class ItalianChef:Chef
    {
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");

        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Italianspecials");

        }
        // it inherits from the superclass(Chef)
    }
}
