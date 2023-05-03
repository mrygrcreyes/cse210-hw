using System;
public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }
    public Fraction (int wholeNumber)
    {
        _topNum = wholeNumber;
        _bottomNum = 1; 
    }

    public Fraction (int topNum, int bottomNum)
    {
        _topNum = topNum;
        _bottomNum = bottomNum;
    }
    public string GetFractionString()
    {
        string FractionString = $"{_topNum}/{_bottomNum}";
        return FractionString;
    }

    public double GetDecimalValue()
    {
        
        return (double)_topNum / (double)_bottomNum;
        
        /* other way to return values
        double decimalValue = (double)_topNum / (double)_bottomNum;
        return decimalValue; */
    }

    

   



}