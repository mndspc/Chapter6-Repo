using System;


namespace FunctionsAndExceptionHandling
{
    //   This program demo. how to use inner exception.
    class InnerExceptionDemo
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.Write("Enter First Number:");
                    int firstNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number:");
                    int secondNum = int.Parse(Console.ReadLine());
                    int ans = firstNum / secondNum;
                    Console.WriteLine("The Answer is:{0}", ans);
                }
                catch (Exception ex)
                {
                    throw new FormatException("Invalid Format",ex);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
             Console.ReadLine();
        }
    }
}
