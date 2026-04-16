namespace StudentInterviewApp;

public delegate void InterviewDelegate();
internal class Student
{
    public event InterviewDelegate Selected;
    public event InterviewDelegate Rejected;
    private int _studentId;

    public int StudentId
    {
        get { return _studentId; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Student Id can not be zero or negative!");
            }
            _studentId = value;
        }
    }
    //Auto Implemented Property [Internally it stores its value in a private backingField]
    public string StudentName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int TotalMarks { get; set; }

    //public string CalculateResult(int totalMarks,out string companyName)
    public string CalculateResult(int totalMarks, ref string companyName)
    {
        if (totalMarks > 80)
        {
            if (Selected!=null)
            {
                Selected();
            }
            companyName = "Bajaj Finserv!";
            return $"Student {StudentName} has been selected for the next round! Congratulation!";
        }
        else
        {
            if (Rejected != null)
            {
                Rejected();
            }
            //companyName = "No Company";
            return $"Student {StudentName} has been rejected for the next round! Better Luck Next Time!";
        }
    }
    public void Companies(params string[] companyName)
    {
        for (int i = 0; i < companyName.Length; i++)
        {
            Console.WriteLine(companyName[i]);
        }
    }
}
