namespace Calculator;

public class Calculator
{
    public static decimal Density(decimal Mass, decimal Volume)
    {
        decimal result = Mass / Volume;

        return result;
    }

    public static decimal Mass(decimal Density, decimal Volume)
    {
        decimal result = Density * Volume;

        return result;
    }

    public static decimal Volume(decimal Mass, decimal Density)
    {
        decimal result = Mass / Density;

        return result;
    }
}