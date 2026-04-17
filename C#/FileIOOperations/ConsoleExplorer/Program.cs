namespace ConsoleExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Explorer!");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType != DriveType.CDRom || drive.DriveType != DriveType.Unknown)
                {
                    Console.WriteLine(drive.Name);
                    DirectoryInfo directoryInfo = new DirectoryInfo(drive.Name);
                    foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
                    {
                        Console.WriteLine($"\t{dir.Name}");
                        try
                        {
                            foreach (var file in dir.GetFiles())
                            {
                                Console.WriteLine($"\t\t{file.Name}");
                            }
                        }
                        catch (UnauthorizedAccessException uae)
                        {
                            Console.WriteLine(uae.Message);
                        }
                    }
                }
            }
        }
    }
}
