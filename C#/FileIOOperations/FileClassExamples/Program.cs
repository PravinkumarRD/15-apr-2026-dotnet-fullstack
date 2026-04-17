namespace FileClassExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple File Operations!");
            string path = @"D:\WebxTraining\.NET-Core-Bajaj-Pune\C#\messages.txt";
            if (!File.Exists(path))
            {
                var FS = File.Create(path);
                FS.Close();
            }
            else
            {
                Console.WriteLine(File.ReadAllText(path));
                File.Delete(path);
            }

            //var SW = File.AppendText(path);
            //SW.WriteLine("Welcome To Bajaj C# Training!");
            //SW.Close();
            //SW.Dispose();

        }
    }
}
