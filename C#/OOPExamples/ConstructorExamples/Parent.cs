namespace ConstructorExamples;

internal class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent Class Default Constructor Executed!");
    }
    public Parent(int a, int b) : this()
    {
        Console.WriteLine("Parent Class Parameterized Constructor Executed!");
        A = a;
        B = b;
    }
    public int A { get; set; }
    public int B { get; set; }
}

internal class Child : Parent
{
    static Child()
    {
        Console.WriteLine("Static Child Constructor!");
    }
    public Child()
    {
        Console.WriteLine("Child Class Default Constructor Executed!");
    }
    public Child(int c, int d) : base(c, d)
    {
        Console.WriteLine("Child Class Parameterized Constructor Executed!");
        C = c;
        D = d;
    }
    public Child(Child child)
    {
        C = child.C;
        D = child.D;
    }
    public int C { get; set; }
    public int D { get; set; }

}
