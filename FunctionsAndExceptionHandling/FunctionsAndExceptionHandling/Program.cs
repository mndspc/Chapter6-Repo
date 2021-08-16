using System;


namespace FunctionsAndExceptionHandling
{
    // The program demo. how to declare functions with some parameters and how to return a value.
    class Program
    {
        static void Main(string[] args)
        {
            //  How to call function from MyMath class
            MyMath math = new MyMath();
            int sum= math.Add(20,30);
            Console.WriteLine("The sum is {0}",sum);
            Console.ReadLine();
        }
    }
}
