using System;


namespace FunctionsAndExceptionHandling
{
    // This program demo. how to catch user-defined exception
    class CatchUserDefinedExcepDemo
    {
        static void Main()
        {
            try
            {
                Employee emp = new Employee();
                Console.Write("Enter Employee Code:");
                int empCode = int.Parse(Console.ReadLine());
                emp.ValidateEmpCode(empCode);
            }
            catch(InvalidEmployeeCode ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
