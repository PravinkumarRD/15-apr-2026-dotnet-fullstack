namespace InterfaceExamples;

internal interface IMath:IAdvanceMath,IBasicMath
{
    
}
internal class BajaMath : IMath
{
    int IBasicMath.Addition(int i, int j)
    {
        return i + j;
    }

    int IAdvanceMath.Addition(int i, int j)
    {
        return i + j + 2000;
    }

    int IAdvanceMath.Multiplication(int i, int j)
    {
        throw new NotImplementedException();
    }

    int IBasicMath.Subtraction(int i, int j)
    {
        throw new NotImplementedException();
    }
}
