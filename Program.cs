using System.Text;

namespace RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(3, 4);

            RationalNumber sum = a + b;
            Console.WriteLine("Сумма: {0}", sum);

            RationalNumber difference = a - b;
            Console.WriteLine("Разность: {0}", difference);

            RationalNumber product = a * b;
            Console.WriteLine("Произведение: {0}", product);

            RationalNumber quotient = a / b;
            Console.WriteLine("Частное: {0}", quotient);

            bool greater = a > b;
            Console.WriteLine("{0} > {1}: {2}", a, b, greater);

            bool equal = a == b;
            Console.WriteLine("{0} == {1}: {2}", a, b, equal);

            Console.WriteLine(a.Info()); // RationalNumber(1/2)
        }
    }
}