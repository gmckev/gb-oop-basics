using System;

namespace Lesson_5_Task_1
{
    internal class RationalNumbers
    {
        static void Main(string[] args)
        {
            Rational r = new Rational(1, 3);
            Rational r2 = new Rational(1, 3);

            Console.WriteLine(r + r2);
            Console.WriteLine(r2.Equals(r));
            Console.WriteLine(r > r2);
            Console.ReadKey();
        }

        public class Rational
        {
            private int _numerator = 0;
            private int _denominator = 1;

            public Rational(int int_value)
            {
                SetValues(int_value, 1);
            }

            public Rational(int new_numerator, int new_denominator)
            {
                SetValues(new_numerator, new_denominator);
            }

            public void SetValues(int new_numerator, int new_denominator)
            {
                if (new_denominator == 0)
                {
                    throw new ArithmeticException("Denominator must not be 0");
                }

                _numerator = new_numerator;
                _denominator = new_denominator;
            }

            public int GetNumerator()
            {
                return _numerator;
            }

            public void SetNumerator(int new_numerator)
            {
                _numerator = new_numerator;
            }

            public int GetDenominator()
            {
                return _denominator;
            }

            public void SetDenominator(int new_denominator)
            {
                if (new_denominator == 0)
                {
                    throw new ArithmeticException("Denominator must not be 0");
                }
                _denominator = new_denominator;
            }

            
            public static int GreatestCommonDivisor(int v1, int v2)
            {
                int tmp;

                if (v1 == 0 || v2 == 0) return 0;

                if (v1 < 0) v1 = -v1;
                if (v2 < 0) v2 = -v2;

                if (v2 > v1)
                {
                    tmp = v1; v1 = v2; v2 = tmp;
                }

                for (; ; )
                {
                    tmp = v1 % v2;
                    if (tmp == 0) return v2;

                    v1 = v2; v2 = tmp;
                }
            }

            private void FixDenominator(Rational other)
            {
                int tmp = _denominator;
                _numerator *= other._denominator;
                _denominator *= other._denominator;

                other._numerator *= tmp;
                other._denominator *= tmp;
            }

            
            private void Regularize()
            {
                int divisor = Math.Sign(_denominator) * GreatestCommonDivisor(_numerator, _denominator);
                if (divisor == 0)
                {
                    _numerator = 0;
                    _denominator = 1;
                }
                else
                {
                    _numerator /= divisor;
                    _denominator /= divisor;
                }
            }

            public static bool operator ==(Rational r1, Rational r2)
            {
                r1.Regularize();
                r2.Regularize();
                return (r1._numerator == r2._numerator && r1._denominator == r2._denominator);
            }

            public static bool operator !=(Rational r1, Rational r2)
            {
                return (r1 != r2);
            }

            public static bool operator <(Rational r1, Rational r2)
            {
                r1.FixDenominator(r2);
                return (r1.GetNumerator() < r2.GetNumerator());
            }

            public static bool operator >(Rational r1, Rational r2)
            {
                return (r2 < r1);
            }

            public override bool Equals(object obj)
            {
                if (obj.GetType() == this.GetType())
                {
                    return (this == (Rational)obj);
                }

                return false;
            }

            public override int GetHashCode()
            {
                return (_numerator | (_denominator << 16));
            }

            public static explicit operator double(Rational r)
            {
                return (double)r._numerator / (double)r._denominator;
            }

            public static explicit operator float(Rational r)
            {
                return (float)r._numerator / (float)r._denominator;
            }

            public static Rational operator +(Rational r)
            {
                return new Rational(r._numerator, r._denominator);
            }

            public static Rational operator -(Rational r)
            {
                return new Rational(-r._numerator, r._denominator);
            }

            public static Rational operator +(Rational r1, Rational r2)
            {
                r1.FixDenominator(r2);
                return new Rational(r1._numerator + r2._numerator, r1._denominator);
            }

            public static Rational operator -(Rational r1, Rational r2)
            {
                r1.FixDenominator(r2);
                return new Rational(r1._numerator - r2._numerator, r1._denominator);
            }

            public static Rational operator *(Rational r1, Rational r2)
            {
                return new Rational(r1._numerator * r2._numerator, r1._denominator * r2._denominator);
            }

            public static Rational operator /(Rational r1, Rational r2)
            {
                if (r2._numerator == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Rational(r1._numerator * r2._denominator, r1._denominator * r2._numerator);
            }

            public override string ToString()
            {
                Regularize();
                if (_denominator == 1) return _numerator.ToString();

                return string.Format("({0}/{1})", _numerator, _denominator);
            }
        }
    }
}
