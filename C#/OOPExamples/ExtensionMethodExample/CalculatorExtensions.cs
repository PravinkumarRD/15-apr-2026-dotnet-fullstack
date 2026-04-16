namespace ExtensionMethodExample;

internal static class CalculatorExtensions
{
    public static double Division(this Calculator calculator,double i, double j)
    {
        return i / j;
    }
}
