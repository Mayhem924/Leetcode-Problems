using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var newArray = PlusOne(new int[] { 1, 2, 3 });  // 1 2 4
            var newArray1 = PlusOne(new int[] { 1, 2, 9 }); // 1 3 0
            var newArray2 = PlusOne(new int[] { 9, 9, 9 }); // 1 0 0 0
        }

        static int[] PlusOne(int[] digits)
        {
            StringBuilder value = new StringBuilder();

            digits.Any((x) =>
            {
                value.Append(x);
                return false;
            });

            BigInteger bigInteger = BigInteger.Parse(value.ToString());
            bigInteger += 1;

            var newArray = bigInteger.ToString().AsSpan().ToArray();

            int[] result = Array.ConvertAll(newArray, new Converter<char, int>((x) => Int32.Parse(x.ToString())));

            return result;
        }
    }
}
