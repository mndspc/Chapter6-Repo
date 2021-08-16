using System;

namespace FunctionsAndExceptionHandling
{
    class MyMath
    {
        public void Add()
        {
            int num1 = 20;
            int num2 = 30;
            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1}={2}",num1,num2, sum);
            return;
        }

        public int Add(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        // How to use byval param.
        public  int Increment(int x)
        {
            x++;
            return x;
        }
        //  How to use byref param.
        public int Increment(ref int x)
        {
            x++;
            return x;
        }

        //  How to use out paramater to return multiple value from a function
        public int MyFunction(out int x,int x1)
        {
            // The out parameter must be assigned
            x = x1;
            int y = 100;
            y++;
            return y;
        }

        //  How to declare optional parameters
        public int Size(int height,int width=10)
        {
            return height * width;
        }

        //  How to declare function with multiple optional param.
        public double CalGst(double proAmount,double gstPerState=4,double gstPerCen=4)
        {
            double gstAmount = proAmount / 100 * (gstPerState + gstPerCen);
            return gstAmount;
        }
        public double CalGst(double proAmount)
        {
            return 10.45;
        }

        // How to pass an array as a paramater to function
        public void printArray(params int[] intArray)
        {
            foreach(var v in intArray)
            {
                Console.WriteLine(v);
            }
        }

        //  How to declare recursive function-function call by itself inside its body.
        public void RecFun(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine(x);
                x++;
                RecFun(x);
            }
        }

        public double CalProAmtWithGst(double proAmt,double perGst)
        {
            try
            {
                double gstAmt = proAmt / 100 * perGst;
                double proAmtWithGst = proAmt + gstAmt;
                return proAmtWithGst;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
