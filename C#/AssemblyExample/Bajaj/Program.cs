using PU=University.SPPU.SinhgadCampus.Pune;
using KO=University.Shivaji.SinhgadCampus.Kolhapur;
namespace Bajaj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PU.RMDEngineeringCollege rMD1 = new PU.RMDEngineeringCollege();
            KO.RMDEngineeringCollege rmd2 = new KO.RMDEngineeringCollege();
        }
    }
}

namespace University
{
    namespace SPPU
    {
        namespace SinhgadCampus
        {
            namespace Pune
            {
                class RMDEngineeringCollege
                {

                }
            }
        }
    }
    namespace Shivaji
    {
        namespace SinhgadCampus
        {
            namespace Kolhapur
            {
                class RMDEngineeringCollege
                {

                }
            }
        }
    }
}