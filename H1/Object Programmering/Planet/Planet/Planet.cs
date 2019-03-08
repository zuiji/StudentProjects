using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    public class Planet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double mass;

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private double diameter;
        public double Diameter
        {
            get {return diameter;}
            set { Diameter = value; }
        }

        private double density;
        public double Density {
            get {return density;}
            set {density = value;}
        }

        private double gravity;
        public double Gravity
        {
            get {return gravity;}
            set {gravity = value;}
        }

        private double rotationPeriod;
        public double RotationPeriod
        {
            get {return rotationPeriod;}
            set {rotationPeriod = value;}
        }

        private double lengthOfDay;
        public double LengthOfDay
        {
            get {return LengthOfDay;}
            set {lengthOfDay = value;}
        }

        private double distanceFromSun;
        public double DistanceFromSun
        {
            get {return distanceFromSun;}
            set {distanceFromSun = value;}
        }

        private double orbitalPeriod;

        public double OrbitalPeriod
        {
            get {return orbitalPeriod;}
            set {orbitalPeriod = value;}
        }

        private double orbitalVelocity;
        public double OrbitalVelocity
        {
            get {return orbitalVelocity;}
            set {orbitalVelocity = value;}
        }

        private int meanTemperature;
        public int MeanTempertaure
        {
            get {return meanTemperature;}
            set {meanTemperature = value;}
        }

        private int numberOfMoons;
        public int NumberOfMoons
        {
            get {return numberOfMoon;}
            set {numberOfMoon = value;}
        }

        private bool ringSystem;
        public bool RingSystem
        {
            get {return ringSystem;}
            set {ringSystem = value;}
        }
    }
}
