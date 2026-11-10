public class Fraction
{
    // 1. Private attributes
    private int _top;
    private int _bottom;

    // 2. No-argument constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 3. Constructor with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 4. Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // 5. Getter for the numerator
    public int GetTop()
    {
        return _top;
    }

    // 6. Setter for the numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // 7. Getter for the denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // 8. Setter for the denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // 9. Return the fractional representation
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // 10. Return the decimal representation
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
