using System;


namespace FunctionsAndExceptionHandling
{
    //  This program shows how can we pass an array as a argument
    class ParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            
            myMath.printArray(11, 22, 33, 44, 55);
            Console.ReadLine();
        }
    }
}
