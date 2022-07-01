﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }
}
