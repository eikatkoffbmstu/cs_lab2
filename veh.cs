using System;
public class Vehicle
{
    protected double x;
    protected double y;
    protected double price;
    protected double speed;
    protected int year;
    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine(x, y);
        Console.WriteLine(price);
        Console.WriteLine(speed);
        Console.WriteLine(year);
    }
}
public class Plane : Vehicle
{
    private double altitude;
    private int passengerCount;
    public Plane(double x, double y, double price, double speed, int year, double altitude, int passengerCount)
        : base(x, y, price, speed, year)
    {
        this.altitude = altitude;
        this.passengerCount = passengerCount;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine(altitude});
        Console.WriteLine(passengerCount);
    }
}
public class Car : Vehicle
{
    private int passengerCount;
    public Car(double x, double y, double price, double speed, int year, int passengerCount)
        : base(x, y, price, speed, year)
    {
        this.passengerCount = passengerCount;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine(passengerCount);
    }
}
public class Ship : Vehicle
{
    private int passengerCount;
    private string port; 

    public Ship(double x, double y, double price, double speed, int year, int passengerCount, string port)
        : base(x, y, price, speed, year)
    {
        this.passengerCount = passengerCount;
        this.port = port;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine(passengerCount);
        Console.WriteLine(port);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Plane(10.5, 20.3, 1500000m, 900.0, 2020, 10000.0, 180),
            new Car(5.0, 15.0, 30000m, 150.0, 2018, 5),
            new Ship(30.0, 40.0, 500000m, 50.0, 2015, 200, "Нью-Йорк")
        };
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
