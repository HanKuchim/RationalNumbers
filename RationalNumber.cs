using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    using System;

    public class RationalNumber
    {
        private int numerator;
        private int denominator;

        // Конструктор класса RationalNumber
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю");

            int gcd = GreatestCommonDivisor(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;

            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }

        // Методы класса RationalNumber

        // Сложение
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            int numerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int denominator = r1.denominator * r2.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // Вычитание
        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            int numerator = r1.numerator * r2.denominator - r2.numerator * r1.denominator;
            int denominator = r1.denominator * r2.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // Умножение
        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            int numerator = r1.numerator * r2.numerator;
            int denominator = r1.denominator * r2.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // Деление
        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            int numerator = r1.numerator * r2.denominator;
            int denominator = r1.denominator * r2.numerator;
            return new RationalNumber(numerator, denominator);
        }

        // Операции сравнения
        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            if (ReferenceEquals(r1, r2))
            {
                return true;
            }

            if ((object)r1 == null || (object)r2 == null)
            {
                return false;
            }

            return r1.numerator == r2.numerator && r1.denominator == r2.denominator;
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }

        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            int numerator1 = r1.numerator * r2.denominator;
            int numerator2 = r2.numerator * r1.denominator;
            return numerator1 < numerator2;
        }

        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r2 < r1;
        }

        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return r1 < r2 || r1 == r2;
        }

        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return r1 > r2 || r1 == r2;
        }
        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();
            else
                return string.Format("{0}/{1}", numerator, denominator);
        }

        public string Info()
        {
            return string.Format("RationalNumber({0})", this);
        }

        // Вспомогательный метод для нахождения наибольшего общего делителя
        private int GreatestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
    
}
