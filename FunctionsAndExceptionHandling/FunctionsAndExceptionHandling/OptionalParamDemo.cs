using System;


namespace FunctionsAndExceptionHandling
{
    // The program demo. how to use optional parameters
    class OptionalParamDemo
    {
        static void Main()
        {
            //  The optional param. is nothing but a paramater with default value.
            MyMath myMath = new MyMath();
            int size = myMath.Size(20,20);
            Console.WriteLine("The Size is:{0}",size);
            Console.ReadLine();
        }
    }
}
