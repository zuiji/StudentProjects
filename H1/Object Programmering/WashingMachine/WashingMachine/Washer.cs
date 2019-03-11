using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Washer
    {
        private bool _isPowerOnOrOff;
        private bool _isDoorOpen;
        private bool _isRunning;

        public bool IsPowerOnOrOff
        {
            get { return _isPowerOnOrOff; }
            private set
            {
                Console.WriteLine("is power on " + value);
                _isPowerOnOrOff = value;
            }
        }

        public bool IsDoorOpen
        {
            get { return _isDoorOpen; }

            private set
            {
                Console.WriteLine("is door open " + value);
                _isDoorOpen = value;
            }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            private set
            {
                Console.WriteLine($"is Running {value}");
                _isRunning = value;
            }
        }

        public Washer()
        {
            IsPowerOnOrOff = false;
            IsRunning = false;
            IsDoorOpen = true;
        }


        public void OpenClose()
        {
            IsRunning = !IsRunning;
            IsDoorOpen = !IsDoorOpen;
        }

        public void Wash(bool eco)
        {
            if (!IsDoorOpen && IsPowerOnOrOff)
            {
                if (eco)
                {
                    Console.WriteLine("Eco is on");
                }
                else
                {
                    Console.WriteLine("Normal Wash");
                }
            }
        }

        public void Fill()
        {
            if (!IsDoorOpen && IsPowerOnOrOff)
            {
                Console.WriteLine("Starting to Fill");
            }
        }

        public void Spin()
        {
            if (!IsDoorOpen && IsPowerOnOrOff)
            {
                Console.WriteLine("Lets give it a Spin");
            }
        }

        public void PowerOnOff()
        {
            IsRunning = false;
            Console.WriteLine(IsPowerOnOrOff ? "powering off" : "Powering on");
            IsPowerOnOrOff = !IsPowerOnOrOff;
        }

    }
}
