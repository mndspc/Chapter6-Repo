using System;
namespace FunctionsAndExceptionHandling
{
    //  This program shows how to use recursive function.
    class RecFunDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            int num = 1;
            myMath.RecFun(num);
            Console.ReadLine();
        }
    }
}
