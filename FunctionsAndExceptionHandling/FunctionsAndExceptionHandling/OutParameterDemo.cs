using System;


namespace FunctionsAndExceptionHandling
{
    //  How to return multiple values from single function using Out parameter
    class OutParameterDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            int num;
            int num1 = 100;
            Console.WriteLine("The result is :{0}", myMath.MyFunction(out num,num1));
            Console.WriteLine("The value of out param is :{0}",num);
            Console.ReadLine();
        }
    }
}
