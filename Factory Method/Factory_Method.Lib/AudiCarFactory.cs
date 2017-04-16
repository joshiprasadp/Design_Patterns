using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method.Lib
{
    public abstract class AudiCarFactory
    {
        private Car _car;

        public Car car
        {
            get { return _car?? (_car = CreateCar()); }
            set { _car = value; }
        }

        protected abstract Car CreateCar();

        public void DoSomeWork()
        {
            Console.WriteLine("Validations are done!");
            car.Drive();
            Console.WriteLine("Build completed!");
        }
    }
}