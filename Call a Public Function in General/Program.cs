class MyClass
{
    public void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();  // Creating an instance
        obj.SayHello();  // Calling the public function
    }
}
