﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03_11_2021.Model
{
    class Gun
    {
        public string Model { get; set; }
        public double Power { get; set; }
        public Gun(string model ,double power)
        {
            Model = model;
            Power = power;
        }
    }
}
