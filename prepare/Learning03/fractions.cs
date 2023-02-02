using System;
public class Fraction
{
    private int _numerator;
    private int _denominator;
    public void SetFraction()
    {
        _numerator = 1;
        _denominator = 1;
    } 
    
    public void SetFraction(int number)
    {
         _numerator = number;
         _denominator = 1;
    }
    public void SetFraction(int number1, int number2)
    {
        _numerator = number1;
        _denominator = number2;
    }

    public string GetFractionString()
    {
        //string numerator = _numerator;
        //string denominator = _denominator;
        return $"{_numerator} / {_denominator}";
    }
    public double GetDecimalValue()
    {
        return (Double)_numerator/ (Double)_denominator;
    }
}
