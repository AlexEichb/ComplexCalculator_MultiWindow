using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eichberger_Alexandra_ComplexCalculator
{
    public class ComplexNumber
    {
        // Properties
        public double Real { get; }
        public double Im { get; }

        // Constructor
        public ComplexNumber(double real, double im)
        {
            Real = real;
            Im = im;
        }

        // Methods
        public string ToString()
        {
            if (Im >= 0) { return Real.ToString() + " " + "+ j" + Im.ToString(); }
            else { return Real.ToString() + " " + "- j" + Im.ToString(); }
        }
        
        public static ComplexNumber operator + (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Im + b.Im);
        }

        public static ComplexNumber operator - (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Im - b.Im);
        }

        public static ComplexNumber operator * (ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.Real * b.Real - a.Im * b.Im;
            double imPart = a.Real * b.Im - a.Im * b.Real;

            return new ComplexNumber(realPart, imPart);
        }
        public static ComplexNumber operator / (ComplexNumber a, ComplexNumber b)
        {
            double nenner = Math.Pow(b.Real,2) + Math.Pow(b.Im,2);
            double realPart = (a.Real * b.Real - a.Im * b.Im) / nenner;
            double imPart = (a.Real * b.Im - a.Im * b.Real) / nenner;

            return new ComplexNumber(realPart, imPart);
        }

    }
}
