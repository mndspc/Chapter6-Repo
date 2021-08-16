using System;


namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to handle exceptions.
    class ExcepDemo
    {
        static void Main()
        {          
           MyMath myMath = new MyMath();
            try
            {
                Console.Write("Enter Product Amount:");
                double proAmt = int.Parse(Console.ReadLine());
                Console.Write("Enter GST Percentage:");
                double gstPer = int.Parse(Console.ReadLine());
                double proAmtWithGst = myMath.CalProAmtWithGst(proAmt, gstPer);
                Console.WriteLine("Product Total Amount is :{0}", proAmtWithGst);
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
           catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am in finally");
                GC.Collect();
            }
            Console.ReadLine();
        }
    }
}
