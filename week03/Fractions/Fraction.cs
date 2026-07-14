using System;
using System.Globalization;

public class Fraction
{
  private int _topNumber;
  private int _bottomNumber;

  public Fraction()
  {
    _topNumber = 1;
    _bottomNumber = 1;
  }

  public Fraction(int top)
  {
    _topNumber = top;
    _bottomNumber = 1;
  }

  public Fraction(int top, int bottom)
  {
    _topNumber = top;
    _bottomNumber = bottom;
  }

  public int GetTopNumber()
  {
    return _topNumber;
  }

  public int GetBottomNumber()
  {
    return _bottomNumber;
  }

  public void SetTopNumber(int number)
  {
    _topNumber = number;
  }

  public void SetBottomNumber(int number)
  {
    _bottomNumber = number;
  }

  public string GetFractionString()
  {
    string text = $"{_topNumber}/{_bottomNumber}";
    return text;
  }

  public double GetDecimalValue()
  {
    double fraction = (double)_topNumber / (double)_bottomNumber;
    return fraction;
  }
}