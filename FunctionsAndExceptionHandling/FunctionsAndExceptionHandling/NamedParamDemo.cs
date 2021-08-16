using System;


namespace FunctionsAndExceptionHandling
{
    // This program demo. how to use named parameters
    class NamedParamDemo
    {
        static void Main()
        {
            //  To deal with multiple optional param. we can use named paramaeters.
            MyMath myMath = new MyMath();
            double proAmt = 1000;
            double gstAmt= myMath.CalGst(proAmt, gstPerCen: 8);
            Console.WriteLine("GST Amount is:{0}",gstAmt);
            myMath.CalGst(2000);
            Console.ReadLine();
        }
    }
}
