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
        #region propertis
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _mass;

        public double Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        private double _diameter;
        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        private int _density;
        public int Density
        {
            get { return _density; }
            set { _density = value; }
        }

        private double _gravity;
        public double Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }

        private double _rotationPeriod;
        public double RotationPeriod
        {
            get { return _rotationPeriod; }
            set { _rotationPeriod = value; }
        }

        private double _lengthOfDay;
        public double LengthOfDay
        {
            get { return _lengthOfDay; }
            set { _lengthOfDay = value; }
        }

        private double _distanceFromSun;
        public double DistanceFromSun
        {
            get { return _distanceFromSun; }
            set { _distanceFromSun = value; }
        }

        private double _orbitalPeriod;

        public double OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            set { _orbitalPeriod = value; }
        }

        private double _orbitalVelocity;
        public double OrbitalVelocity
        {
            get { return _orbitalVelocity; }
            set { _orbitalVelocity = value; }
        }

        private short _meanTemperature;
        public short MeanTemperature
        {
            get { return _meanTemperature; }
            set { _meanTemperature = value; }
        }

        private byte _numberOfMoons;
        public byte NumberOfMoons
        {
            get { return _numberOfMoons; }
            set { _numberOfMoons = value; }
        }

        private bool _isRingSystem;
        public bool IsRingSystem
        {
            get { return _isRingSystem; }
            set { _isRingSystem = value; }
        }

        #endregion
        public Planet()
        {

        }
        public Planet(string name, double mass, double diameter, int density, double gravity, double rotationPeriod, double lengthOfDays, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, short meanTemperature, byte numberOfMoons, bool isRingSystem)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDays;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoons;
            IsRingSystem = isRingSystem;
        }
    }
}
