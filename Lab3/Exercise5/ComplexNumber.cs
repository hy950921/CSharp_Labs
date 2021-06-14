using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        private int real;
        private int imaginary;

        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public void SetReal(int real)
        {
            this.real = real;
        }
        public int GetReal()
        {
            return real;
        }
        public void SetImaginary(int imag)
        {
            this.imaginary = imag;
        }
        public int GetImaginary()
        {
            return imaginary;
        }
        public override string ToString()
        {
            string output = $"({real}, {imaginary})";
            return output;
        }
        public double GetMagnitude()
        {
            int squres = real * real + imaginary * imaginary;
            return Math.Sqrt(squres);
        }
        public void Add(ComplexNumber n)
        {
            this.real +=  n.real;
            this.imaginary += n.imaginary;
        }



    }
}
