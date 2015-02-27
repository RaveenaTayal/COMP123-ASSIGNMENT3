using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT3
{

    //Creating GiantPlanet subclass that inherits from Planet base class and implements IHasMoons and IHasRings interfaces.
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {

        //PRIVATE INSTANCE VARIABLES--------------------------------------------------------------------
        private bool _oxygen;

        //CONSTRUCTORS----------------------------------------------------------------------------------
        public TerrestrialPlanet(string name,double diameter,double mass,bool oxygen)
            :base(name,diameter,mass)
        {

            //Assign local variable to instance variable------------------------------------------------
            this._oxygen = oxygen;
        }

        //PUBLIC METHODS--------------------------------------------------------------------------------
        public bool HasMoons()
        {

            //Check whether the MoonCount is greater than 0 and display true otherwise display false----
            return (base.MoonCount > 0) ? true : false;
        }
        public bool Habitable()
        {

            //Check whether the oxygen variable holds true or false ------------------------------------
            return (this._oxygen) ? true : false;
        }


    }
}
