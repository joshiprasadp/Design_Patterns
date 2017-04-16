using Factory_Method.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var audiFamilyCar = new FamilyCarFactory();
            audiFamilyCar.DoSomeWork();
            Console.ReadLine();

        }

         
    }
}
