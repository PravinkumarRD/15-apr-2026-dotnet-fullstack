namespace StudentInterviewApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Student Interview App!");
		try
		{
			Student student = new Student();
			student.Selected += OracleDb;
			student.Rejected += MSSQLDb;
			student.StudentId = 10;
			student.StudentName = "Pravinkumar R. D.";
			student.Email = "pravin@bajaj.com";
			student.City = "Pune";
			student.TotalMarks = 98;
            if (student.TotalMarks>=95)
            {
                student.Selected += SendEmail;
            }
            string company = string.Empty ;
            //string result = student.CalculateResult(student.TotalMarks,out company);
            string result = student.CalculateResult(student.TotalMarks, ref company);
            Console.WriteLine(result);
            Console.WriteLine(company);
			student.Companies("Bajaj", "Bajaj Finserv", "Infosys", "Synechron");
		}
		catch(ArgumentException ae)
		{
			Console.WriteLine(ae.Message);
		}
		catch (Exception ex)
		{
            Console.WriteLine(ex.Message);
		}
    }
	public static void OracleDb()
	{
        Console.WriteLine("Student's Data Stored in Oracle Database");
	}
    public static void SendEmail()
    {
        Console.WriteLine("Student's Data Send to CTO!");
    }
    public static void MSSQLDb()
    {
        Console.WriteLine("Student's Data Stored in Microsoft SQL Server Database");
    }
}
