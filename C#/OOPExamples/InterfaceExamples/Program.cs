namespace InterfaceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Examples!");
            IPhysics physics = new Science();
            Console.WriteLine(physics.PhysicsDepartment());
            IBiology biology=new Science();
            Console.WriteLine(biology.BiologyDepartment());
            IChemistry chemistry=new Science();
            Console.WriteLine(chemistry.ChemistryDepartment());

            IScienceHead scienceHead = new Science();
            IMath math =new  BajaMath();
            math.
        }
    }
}
