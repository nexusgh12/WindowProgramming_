using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionProgram
{
    class Fraction
    {
        int numerator1, numerator2, numerator3;
        int denominator1, denominator2, denominator3;
        int gcd;

        //생성자
       public Fraction(int numerator1, int denominator1, int numerator2, int denominator2)
        {
            this.numerator1 = numerator1;
            this.numerator2 = numerator2;
            this.denominator1 = denominator1;
            this.denominator2 = denominator2;
       }
       public void Calc()
        {
            if (denominator1 == denominator2)
            {
                this.denominator3 = denominator1;
                this.numerator3 = numerator1 + numerator2;
            }
            else
            {
                //통분
                this.numerator3 = (numerator1 * denominator2 + numerator2 * denominator1);
                this.denominator3 = (denominator1 * denominator2);
                gcd = GCD(numerator3, denominator3);
                this.numerator3 /= gcd;
                this.denominator3 /= gcd;
            }

        }
        public int GCD(int a, int b)
        {
            return (a % b == 0 ? b : GCD(b, a % b));
        }

        public int GetNumerator3()
        {
            return numerator3;
        }
        public int GetDenominator3()
        {
            return denominator3;
        }

    }
}
