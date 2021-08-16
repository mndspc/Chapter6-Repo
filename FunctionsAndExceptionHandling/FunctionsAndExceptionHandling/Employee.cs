using System;


namespace FunctionsAndExceptionHandling
{
    // This program demo. how to throw an exception
    class Employee
    {
        public void ValidateEmpCode(int empCode)
        {
            if (empCode <= 0)
            {
                throw new InvalidEmployeeCode();
            }
        }
    }
}
