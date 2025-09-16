using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Removed duplicate constructor with same signature as below
    public Fraction(int wholeNumber)

    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public string GetFractionString()
    {
        // Return the fraction as a string
        // temporary, local variable
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        // Return the decimal value of the fraction
        // temporary, local variable
        //computed each time the method is called
        return (double)_numerator / (double)_denominator;

    }

}   
        
    

    
    
    
