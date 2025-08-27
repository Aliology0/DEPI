using System;

class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = c1.Real * c2.Real;
        double imaginaryPart = c1.Imaginary * c2.Imaginary;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}