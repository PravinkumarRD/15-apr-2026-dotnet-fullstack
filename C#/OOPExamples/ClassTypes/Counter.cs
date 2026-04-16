namespace ClassTypes;

//Sharing the data and logic
internal static class Counter
{
    private static int Count { get; set; } = 1;
    public static int IncrementCounter()
    {
        return Count++; 
    }
}
