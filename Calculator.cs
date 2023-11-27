using System;

public class Calculator
{
	public Calculator() { }

		 public int addInteger(int integer1, int integer2)
		{
			int sum = integer1 + integer2;
			return sum;
		}
	public double addDouble(double first, double second)
	{
		double sum = first + second;
		return sum;
	}
    public String addStrings(String string1, String string2)
    {
        String sum = string1 + string2;
        return sum;
    }
    public float addFloat(float first, float second)
    {
        float sum = first + second;
        return sum;
    }
    public float substractFloat(float first, float second)
    {
        float sum = first - second;
        return sum;
    }
    public double substractDouble(double first, double second)
    {
        double sum = first - second;
        return sum;
    }
    public double multiplyDouble(double first, double second)
    {
        double sum = first * second;
        return sum;
    }
    public double divideDouble(double first, double second)
    {
        double sum = first / second;
        return sum;
    }
    

}

