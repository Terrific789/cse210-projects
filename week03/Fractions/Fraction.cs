using System;

public class Fraction{
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    // Parameterized constructor
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

// Getters and Setters for the _top
    public int GetTop(){
        return _top;
    }

    public void SetTop(int top){
        _top = top;
    }

// Getters and Setters for the _bottom
    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int bottom){
            _bottom = bottom;
        }

    public string GetFractionString(){
        string display = $"{_top}/{_bottom}";
        return display;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}

