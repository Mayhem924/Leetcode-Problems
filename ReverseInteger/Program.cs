using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"123 -> {ReverseInt(123)}");     // 321
            Console.WriteLine($"-123 -> {ReverseInt(-123)}");   // -321
            Console.WriteLine($"120 -> {ReverseInt(120)}");     // 21

            Console.ReadLine();
        }

        static int ReverseInt(int x)
        {
            int tempInt;

            try
            {
                tempInt = Math.Abs(x);
            }
            catch (OverflowException)
            {
                return 0;
            }

            var tempStr = tempInt.ToString();
            var chars = tempStr.ToCharArray();

            Array.Reverse(chars);
            tempStr = String.Empty;

            foreach (var item in chars)
            {
                tempStr += item;
            }

            try
            {
                tempInt = Convert.ToInt32(tempStr);
            }
            catch (OverflowException)
            {
                tempInt = 0;
            }


            if (x < 0)
            {
                tempInt = -tempInt;
            }

            return tempInt;
        }
    }
}
