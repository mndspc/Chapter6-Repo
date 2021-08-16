using System;
namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to take user-defined type and how to return it.
    class WorkWithUSerDefinedTypes
    {
        static void Main()
        {
            Console.Write("Enter a Roll No:");
            int rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter a Name:");
            string name = Console.ReadLine();
            Console.Write("Enter a Email:");
            string email = Console.ReadLine();

            Student stdObj = new Student();
            var student= stdObj.Add(rollNo, name, email);
            Console.WriteLine("Roll No={0} Name={1} Email={2}",student.StdRollNo,student.StdName,stdObj.Email);

            Student[] stdArray = new Student[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a Roll No:");
                int stdno = int.Parse(Console.ReadLine());
                Console.Write("Enter a Name:");
                string stdname = Console.ReadLine();
                Console.Write("Enter a Email:");
                string stdemail = Console.ReadLine();
                Student std = new Student {StdRollNo= stdno,StdName= stdname ,Email= stdemail };
                stdArray[i] = std;
            }

            // Object Intializer syntax
            //Student[] stdArray = new Student[] {
            //    new Student{StdRollNo=100,StdName="Scott",Email="scott@gmail.com"},
            //    new Student{StdRollNo=101,StdName="Tiger",Email="tiger@gmail.com"},
            //    new Student{StdRollNo=102,StdName="Smith",Email="smith@gmail.com"},
            //};

            Console.WriteLine("===========Student Details are:====================");

           var stdList= stdObj.AddRange(stdArray);
            foreach(var std in stdList)
            {
                Console.WriteLine("Roll No={0} Name={1} Email={2}", std.StdRollNo, std.StdName, std.Email);
            }
            Console.ReadLine();
        }
    }
}
