using System;


namespace FunctionsAndExceptionHandling
{
    //  How to use settings variables
    class SettingsDemo
    {
      
        static void Main()
        {
            //  How to set value to settings variable
            FunctionsAndExceptionHandling.Settings1.Default.username = "Scott";
            //  How to get value from settings variable
            Console.WriteLine("Welcome User:{0}",FunctionsAndExceptionHandling.Settings1.Default.username);
            Console.ReadLine();
        }
    }
}
