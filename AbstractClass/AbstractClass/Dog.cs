﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
}
