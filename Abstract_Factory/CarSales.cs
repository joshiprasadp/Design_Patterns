using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Main
{
    public class CarSales : ICarSales
    {
        private CarFactory AudiCarFactory { get; set; }
        private CarFactory MercedesCarFactory { get; set; }


        private CarFactory MakeAudiCarFactory()
        {
            return new AudiFactory();
        }

        private CarFactory MakeMercCarFactory()
        {
            return new MercedesFactory();
        }

        public FamilyCar GetFamilyCar(string Company)
        {
            if (Company.CompareTo("Audi")==0)
            {
                return (AudiCarFactory??(AudiCarFactory=MakeAudiCarFactory())).CreateFamilyCar();
            }
            else
            {
                return (MercedesCarFactory??(MercedesCarFactory=MakeMercCarFactory())).CreateFamilyCar();
            }


        }

        public SportsCar GetSportsCar(string Company)
        {
            if (Company.CompareTo("Audi") == 0)
            {
                return (AudiCarFactory??(AudiCarFactory=MakeAudiCarFactory())).CreateSportsCar();
            }
            else
            {
                return (MercedesCarFactory??(MercedesCarFactory=MakeMercCarFactory())).CreateSportsCar();
            }
        }
    }
}
