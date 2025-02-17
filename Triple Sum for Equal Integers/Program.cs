using System;
namespace exercise;
public class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine(test(1,4));
        Console.WriteLine(test(1,3));
        Console.WriteLine(test(2,2));
        Console.ReadLine();

    }
    public static int test(int x, int  y)
    {
        return x == y ? (x+y)*3 : x + y;


    }
    

    
}