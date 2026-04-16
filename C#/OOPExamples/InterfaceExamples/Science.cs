namespace InterfaceExamples;

internal class Science : IScienceHead
{
    string IBiology.BiologyDepartment()
    {
        return "Biology Department Method!";
    }

    string IChemistry.ChemistryDepartment()
    {
        return "Chemistry Department Method!";
    }

    string IPhysics.PhysicsDepartment()
    {
        return "Physics Department Method!";
    }
}
