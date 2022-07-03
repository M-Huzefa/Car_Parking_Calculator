class Vehicle
{
    protected double initial;
    protected double increment;
    protected double maximum;
    protected double time = 0;

    public void Cal(double time)
    {
        double total;
        if (time <= 3)
        {
            Console.WriteLine("Fare for {0} is ${1}", time, initial);
        }
        if (time >= 3)
        {
            total = initial + increment * (time - 3);
            if (total > maximum)
            {
                Console.WriteLine("Fare for {0} is ${1}", time, maximum);
            }
            else
            {
                Console.WriteLine("Fare for {0} is ${1}", time, total);
            }
        }
    }
}

class Bus : Vehicle
{
    public Bus(double ini, double incre, double max)
    {
        initial = ini;
        increment = incre;
        maximum = max;
    }
}

class Car : Vehicle
{
    public Car(double ini, double incre, double max)
    {
        initial = ini;
        increment = incre;
        maximum = max;
    }
}

class Bike : Vehicle
{
    public Bike(double ini, double incre, double max)
    {
        initial = ini;
        increment = incre;
        maximum = max;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Vehicle bus = new Bus(6, 1.5, 30);
        Vehicle car = new Car(4, 1, 20);
        Vehicle bike = new Bike(2, 0.5, 10);
        Console.WriteLine("In case of Bus: ");
        bus.Cal(24);
        bus.Cal(5);
        bus.Cal(1);
        Console.WriteLine("In case of Car: ");
        car.Cal(24);
        car.Cal(5);
        car.Cal(1);
        Console.WriteLine("In case of Bike: ");
        bike.Cal(24);
        bike.Cal(5);
        bike.Cal(1);
    }
}