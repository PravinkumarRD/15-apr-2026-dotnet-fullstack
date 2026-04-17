namespace BajajConferenceWithTaskContinuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                Task<List<Employee>> transferEmployeesToPune = Task<List<Employee>>.Run(()=>GetAllEmployees())
                    .ContinueWith(allEmployees =>
                    {
                        var allMumbaiEmployees = allEmployees.Result.Where(e => e.City == "Mumbai");
                        return allMumbaiEmployees.ToList();
                    }).ContinueWith(mumbaiEmployees =>
                    {
                        foreach (var emp in mumbaiEmployees.Result)
                        {
                            emp.City = "Pune";
                        }
                        return mumbaiEmployees.Result;
                    }).ContinueWith(transferedEmployees =>
                    {
                        foreach (var emp in transferedEmployees.Result)
                        {
                            Console.WriteLine($"Employee {emp.EmployeeName} has been shifted to city {emp.City}!");
                        }
                        return transferedEmployees.Result;
                    });
                transferEmployeesToPune.Wait();
                Console.WriteLine("End of Program!");
                
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Done!");
        }
        private static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new(){EmployeeId=1,EmployeeName="Alisha C.",City="Mumbai"},
                new(){EmployeeId=2,EmployeeName="Varun Patil",City="Mumbai"},
                new(){EmployeeId=1,EmployeeName="Anjali Sharma",City="Delhi"},
                new(){EmployeeId=1,EmployeeName="Manish Verma",City="Delhi"},
                new(){EmployeeId=1,EmployeeName="John Mark",City="Berlin"},
                new(){EmployeeId=1,EmployeeName="Maria Andrus",City="London"},
            };
        }
    }
}
