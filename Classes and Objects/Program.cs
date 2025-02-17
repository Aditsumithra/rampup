class Car
{
    public string Brand;
    public string Model;

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Brand = "Tesla";
        car1.Model = "Model S";
        car1.DisplayInfo();
    }
}
