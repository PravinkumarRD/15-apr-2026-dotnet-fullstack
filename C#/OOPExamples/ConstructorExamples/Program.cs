namespace ConstructorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Examples!");
            Child child1 = new Child();
            Child child2 = new Child(100, 200);
            Child child3 = new Child(child2);
            Console.WriteLine($"Child - 3 - {child3.C} {child3.D}");
        }
    }
}
