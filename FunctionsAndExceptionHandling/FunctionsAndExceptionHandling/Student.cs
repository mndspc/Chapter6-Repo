using System;
using System.Collections.Generic;

namespace FunctionsAndExceptionHandling
{
    //  To take and return user-defined types from and to function
    class Student
    {
        public int StdRollNo { get; set; }
        public string StdName { get; set; }
        public string Email { get; set; }

        public Student Add(int rollNo,string name,string email)
        {
            this.StdRollNo = rollNo;
            this.StdName = name;
            this.Email = email;
            return this;
        }

        public List<Student> AddRange(Student[] stdArray)
        {

            // To create List of student using Object Initializer syntax
            List<Student> stdList = new List<Student>();
            foreach(var student in stdArray)
            {
                stdList.Add(student);
            }

            return stdList;
        }
    }
}
