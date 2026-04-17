namespace AsyncAwaitMethod
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Main Thread Id is {Thread.CurrentThread.ManagedThreadId} !");
                Console.WriteLine("Program Started!");
                var employees = await GetAllEmployeesAsync();
                var cityWiseEmployees = await FilterAllEmployeesAsync(employees, "Delhi");
                var transferEmployees = await ShiftAllEmployeesAsync(cityWiseEmployees, "Bangalore");
                await LogTransferedEmployeesAsync(transferEmployees);
                Console.WriteLine("Program Ended");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Task<List<Employee>> GetAllEmployeesAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"GetAllEmployeesAsync Thread Id is {Thread.CurrentThread.ManagedThreadId} !");
                return GetAllEmployees();
            });
        }
        private static Task<List<Employee>> FilterAllEmployeesAsync(List<Employee> employees, string city)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"FilterAllEmployeesAsync Thread Id is {Thread.CurrentThread.ManagedThreadId} !");
                return employees.Where(e => e.City == city).ToList();
            });
        }
        private static Task<List<Employee>> ShiftAllEmployeesAsync(List<Employee> filteredEmployee, string newCity)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ShiftAllEmployeesAsync Thread Id is {Thread.CurrentThread.ManagedThreadId} !");
                foreach (var employee in filteredEmployee)
                {
                    if (employee.City == "Delhi") throw new ArgumentException("Can not transfer Delhi employees!");
                    employee.City = newCity;
                }
                return filteredEmployee;
            });
        }
        private static Task LogTransferedEmployeesAsync(List<Employee> employees)
        {
            Console.WriteLine($"LogTransferedEmployeesAsync Thread Id is {Thread.CurrentThread.ManagedThreadId} !");
            foreach (var item in employees)
            {
                Console.WriteLine($"Employee {item.EmployeeName} has been transfered to city {item.City}!");
            }
            return Task.CompletedTask;
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
