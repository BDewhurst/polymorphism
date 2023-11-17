﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism {
    class Program {
        static void Main (string[] args) {

            var cars = new List<Car> 
            {
                new Audi("Red", 120, "A3"), 
                new Bmw("Blue", 120, "6 series")

                 };

                foreach (var car in cars)
                {
                    car.Repair();
                    car.ShowDetails();
                }
           

        }
    }
}