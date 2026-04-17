namespace StreamHandlerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stream Reader and Writer!");
            string path = @"D:\WebxTraining\.NET-Core-Bajaj-Pune\C#\logs.txt";
            //using (Sample sample=new Sample())
            //{

            //}
            using (StreamWriter SW = new StreamWriter(path, true))
            {
                SW.WriteLine("Welcome To India!");
                SW.WriteLine("Welcome To Pune!");
                SW.WriteLine("Welcome To Bajaj!");
                SW.Close();
            }
            using (StreamReader SR = new StreamReader(path))
            {
                // Console.WriteLine(SR.ReadToEnd());
                while (SR.Peek() != -1)
                {
                    Console.WriteLine(Convert.ToChar(SR.Read()));
                }
                SR.Close();
            }
        }
    }

    class Sample : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose is called!");
        }
    }
}
