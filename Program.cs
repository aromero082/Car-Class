using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        private static IEnumerable<object> carList;

        static void Main(string[] args)
        {
            Car car = new Car();
            myCar Make = "Toyota";
            myCar Model = "Tundra";
            myCar Year = 2015;


            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }

        }
        
            



    }
}
