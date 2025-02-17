using System;

public class PrimeNumberExample
{
    // Public method to check if a number is prime
    public bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the Number to check Prime: ");
        int num = int.Parse(Console.ReadLine());

        // Creating an instance of the class to call the public method
        PrimeNumberExample primeCheck = new PrimeNumberExample();

        // Calling the public function
        bool result = primeCheck.IsPrime(num);

        // Printing result
        if (result)
            Console.WriteLine("Number is Prime.");
        else
            Console.WriteLine("Number is not Prime.");
    }
}
