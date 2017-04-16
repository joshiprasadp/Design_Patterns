//using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();
            //container.RegisterType<IMercedesFactory, MercedesFactory>();

            CarSales sales = new CarSales();
            var aFamilycar = sales.GetFamilyCar("Merc");
            aFamilycar.drive();

            var aSportsCar = sales.GetSportsCar("Audi");
            aSportsCar.drive();
            //CarFactory audiFactory = new AudiFactory();
            //FamilyCar audiFamilyCar =  audiFactory.CreateFamilyCar();
            //audiFamilyCar.drive();
            //SportsCar audiSportsCar = audiFactory.CreateSportsCar();
            //audiSportsCar.drive();

            //CarFactory mercedesFactory = new MercedesFactory();
            //FamilyCar mercedesFamilyCar = mercedesFactory.CreateFamilyCar();
            //mercedesFamilyCar.drive();

            //SportsCar mercedesSportsCar = mercedesFactory.CreateSportsCar();
            //mercedesSportsCar.drive();

            Console.ReadLine();
        }
    }
}
