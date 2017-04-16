using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method.Lib
{
    public class FamilyCar : Car
    {
        public FamilyCar()
        {
            Console.WriteLine(GetType().Name);
        }

        public override void Drive()
        {
            Console.WriteLine("Driving slow because this is family car.....");
        }
        
    }
}