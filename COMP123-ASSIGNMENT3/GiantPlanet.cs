using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT3
{

    //Creating GiantPlanet subclass that inherits from Planet base class and implements IHasMoons and IHasRings interfaces.
    class GiantPlanet:Planet,IHasMoons,IHasRings
    {

        //PRIVATE INSTANCE VARIABLES--------------------------------------------------------------------
        private string _type;

        //CONSTRUCTORS----------------------------------------------------------------------------------
        public GiantPlanet(string name,double diameter,double mass,string type)
            :base(name,diameter,mass)
        {

            //Assign local variable to instance variable------------------------------------------------
            this._type = type;
        }

        //PUBLIC METHODS--------------------------------------------------------------------------------
        public bool HasMoons()
        {
            //Check whether the MoonCount is greater than 0 and display true otherwise display false----
            return (base.MoonCount > 0) ? true : false;
        }

        public bool HasRings()
        {
            //Check whether the RingCount is greater than 0 and display true otherwise display false----
            return (base.RingCount > 0) ? true : false;
        }
    }
}
