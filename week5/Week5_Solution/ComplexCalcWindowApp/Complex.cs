using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalcWindowApp
{
    class Complex
    {
        private double real;
        private double imaginary;
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;

        }
        public double Real
        {
            get
            {
                return this.real;
            }
            set
            {
                this.real = value;
            }
        }
        public double Imaginary
        {
            get
            {
                return this.imaginary;
            }
            set
            {
                this.imaginary = value;
            }
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex((c1.real * c2.real) - (c1.imaginary * c2.imaginary), (c1.real * c2.imaginary) + (c1.imaginary * c2.real));
        }
    }
}
