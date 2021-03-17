using System;

namespace Variable_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint = 20;
            double mydouble = 13.77;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myint));
            Console.WriteLine(Convert.ToDouble(myint));
            Console.WriteLine(Convert.ToInt32(mydouble));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
