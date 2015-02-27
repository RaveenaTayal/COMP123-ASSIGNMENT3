/*
 *Author: Raveena Tayal
 *Last Modified on 2/27/2015
 *Program Description: Create a Planet base class and IHasMoons, IHasRings and IHabitable interfaces. Create 
 *                     GiantPlanet subclass that inherits from Planet class and implements IHasMoons and IHasRings
 *                     interfaces. Create another subclass TerrestrialPlanet that inherits from Planet class and
 *                     implements IHasMoons and Ihabitable interfaces. Implement your program by creating objects
 *                     for the GiantPlanet and TerrestrialPlanet classes in the main method.
 *Revision History: 
 *                 Revision: 5
 *                 Modified: 2/27/2015(5:20pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Revised the entire project.
 *                 -----------------------------------------------------------------------
 *                 Revision: 4
 *                 Modified: 2/27/2015(5:15pm)
 *                 Author: Raveena Tayal             
 *                 Log Entry: Added extra functionality to the program
 *                 -----------------------------------------------------------------------
 *                 Revision: 3
 *                 Modified: 2/27/2015(4:28pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Implemented GiantPlanet and TerrestrialPlanet class by creating objects
 *                 -----------------------------------------------------------------------
 *                 Revision: 2
 *                 Modified: 2/27/2015(3:24pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Added GiantPlanet and Terrestrial planet sub classes
 *                 -----------------------------------------------------------------------
 *                 Revision: 1
 *                 Modified: 2/27/2015(3:06pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Added Planet class, IHasMoons, IHasRings and IHabitable interfaces to the c# project
 *                 -----------------------------------------------------------------------
 */
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

            //Giant Planet----------------------------------------------------------------------------
            string giantName="Jupiter";
            Console.WriteLine("**************************************************");
            Console.WriteLine("Giant Planet: {0}", giantName);

            //Creating an object for GiantPlanet class------------------------------------------------
            GiantPlanet giant = new GiantPlanet(giantName, 139822, 1.898E27, "Gas");
            Console.WriteLine(giant.ToString());
            Console.WriteLine("Okay, lets explore some facts about {0}.", giantName);
            Console.WriteLine("What u think? Is {0} a 'Gas' planet or 'Ice' planet?? ", giantName);
            string type = Console.ReadLine();
            //Check whether the user knows whether planet is gas planet or ice planet-----------------
            if(type==giant.Type)
            {
                Console.WriteLine("Smart Answer!!!! ");
            }
            else
            {
                Console.WriteLine("Oh no !!! {0} is {1} planet", giantName, giant.Type);
            }

            Console.WriteLine("Do you think {0} has moons?? Press y if u think so", giantName);
            char moons=Convert.ToChar(Console.ReadLine());
            //Check whether planet has moons----------------------------------------------------------
            if (giant.MoonCount > 0)
            {
                Console.WriteLine("{0} has moons", giantName);
            }
            else
            {
                Console.WriteLine("{0} doesnot have moons", giantName);
            }

            Console.WriteLine("Do you think {0} has rings?? Press y if u think so", giantName);
            char rings=Convert.ToChar(Console.ReadLine());
            //Check whether the planet has rings or not-----------------------------------------------
            if (giant.RingCount > 0)
            {
                Console.WriteLine("{0} has rings", giantName);
            }
            else
            {
                Console.WriteLine("{0} doesnot have rings", giantName);
            }
            Console.WriteLine("**************************************************");
            Console.WriteLine();

            //Terrestrtial Planet---------------------------------------------------------------------
            string terrestrialName="Mercury";
            Console.WriteLine("**************************************************");
            Console.WriteLine("Terrestrial Planet: {0}", terrestrialName);

            //Creating an object for TerrestrialPlanet class------------------------------------------
            TerrestrialPlanet terrestrial = new TerrestrialPlanet(terrestrialName, 4878, 328.5E21, true);            
            Console.WriteLine(terrestrial.ToString());
            Console.WriteLine("Okay, lets explore some facts about {0}.", terrestrialName);
            Console.WriteLine("Do you think {0} has moons?? Press y if u think so", terrestrialName);
            moons = Convert.ToChar(Console.ReadLine());
            //Check whether planet has moons----------------------------------------------------------
            if (terrestrial.MoonCount > 0)
            {
                Console.WriteLine("{0} has moons", terrestrialName);
            }
            else
            {
                Console.WriteLine("{0} doesnot have moons", terrestrialName);
            }

            Console.WriteLine("Wait. Do you think {0} is habitable Press y if u think so ", terrestrialName);
            char habitable = Convert.ToChar(Console.ReadLine());
            //Check whether planet is habitable-------------------------------------------------------
            if(terrestrial.Habitable())
            {
                Console.WriteLine("{0} has oxygen so it is habitable", terrestrialName);
            }
            else
            {
                Console.WriteLine("Oh {0} doesnot have oxygen so it's not habitable", terrestrialName);
            }
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            
            Console.WriteLine();
            //Show output on console -----------------------------------------------------------------
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
