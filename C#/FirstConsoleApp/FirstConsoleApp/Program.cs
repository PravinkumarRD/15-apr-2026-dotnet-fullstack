namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Flight Booking App!");
            try
            {
                Console.WriteLine("Please enter your name - ");
                string? name = Console.ReadLine();
                Console.WriteLine("Please enter your age - ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 80)
                {
                    Console.WriteLine($"Person {name} can not travel by air due to age limit!");
                }
                else
                {
                    Console.WriteLine($"Person {name} can travel by air! Please proceed to ticket counter!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
