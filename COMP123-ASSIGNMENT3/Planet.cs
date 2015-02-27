using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT3
{
    class Planet
    {

        //PRIVATE INSTANCE VARIABLES------------------------------------------------------
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES---------------------------------------------------------------
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //CONSTRUCTORS----------------------------------------------------------------------
        public Planet(string name, double diameter, double mass)
        {

            //Assign local variables to instance variables----------------------------------
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //OVERRIDDEN METHODS----------------------------------------------------------------
        public override string ToString()
        {

            //Return the Name, Diameter and mass -------------------------------------------
            return this._name + " has:\n\tDiameter: " + this._diameter + " km \n\tMass: " + this._mass+" kg ";
        }
    }
}
