using System;

namespace car_parking_calculator
{
    class Vehicle
    {
        protected double initial;
        protected double increment;
        protected double maximum;

        public void Calculator (double time)
        {
            double total;
            if (time <= 3)
            {
                Console.WriteLine("Fare for {0} hours is ${1}", time, initial);
            }
            if (time >= 3)
            {
                total = initial + increment * (time - 3);
                if (total > maximum)
                {
                    Console.WriteLine("Fare for {0} hours is ${1}", time, maximum);
                }
                else
                {
                    Console.WriteLine("Fare for {0} hours is ${1}", time, total);
                }
            }
        }
    }

    class Bus : Vehicle
    {
        public Bus()
        {
            initial = 6;
            increment = 1.5;
            maximum = 30;
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            initial = 4;
            increment = 1;
            maximum = 20;
        }
    }

    class Bike : Vehicle
    {
        public Bike()
        {
            initial = 2;
            increment = 0.5;
            maximum = 10;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bus = new Bus();
            Vehicle car = new Car();
            Vehicle bike = new Bike();
            Console.WriteLine("In case of Bus: ");
            bus.Calculator(24);
            bus.Calculator(5);
            bus.Calculator(1);
            Console.WriteLine(); Console.WriteLine("In case of Car: ");
            car.Calculator(24);
            car.Calculator(5);
            car.Calculator(1);
            Console.WriteLine(); Console.WriteLine("In case of Bike: ");
            bike.Calculator(24);
            bike.Calculator(5);
            bike.Calculator(1);
        }
    }
}
