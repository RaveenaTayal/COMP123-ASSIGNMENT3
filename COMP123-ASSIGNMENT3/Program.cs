using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT3
{
    class Program
    {
        static void Main(string[] args)
        {

            string giantName="Jupiter";
            Console.WriteLine("**************************************************");
            Console.WriteLine("Giant Planet: {0}", giantName);
            GiantPlanet giant = new GiantPlanet(giantName, 139822, 1.898E27, "Gas");
            Console.WriteLine(giant.ToString());
            Console.WriteLine("**************************************************");
            Console.WriteLine();

            string terrestrialName="Mercury";
            Console.WriteLine("**************************************************");
            Console.WriteLine("Terrestrial Planet: {0}", terrestrialName);
            TerrestrialPlanet terrestrial = new TerrestrialPlanet(terrestrialName, 4878, 328.5E21, true);            
            Console.WriteLine(terrestrial.ToString());
            Console.WriteLine("**************************************************");
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
