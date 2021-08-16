using System;


namespace FunctionsAndExceptionHandling
{
    class ByValAndByRefDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            int num=99;
            //  Calling function with ByVal paramater
            Console.WriteLine("The result is:{0}", myMath.Increment(num));
            Console.WriteLine("Value of num is :{0}",num);
            //  Calling function with ByRef parameter
            Console.WriteLine("The result is:{0}", myMath.Increment(ref num));
            Console.WriteLine("Value of num is:{0}",num);

            Console.ReadLine();
        }
    }
}
