﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public abstract class FamilyCar 
    {
        public void drive()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}