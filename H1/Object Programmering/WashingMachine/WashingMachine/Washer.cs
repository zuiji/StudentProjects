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

        public  bool IsPowerOnOrOff
        {
            get {return _isPowerOnOrOff;}
        }

        public bool IsDoorOpen
        {
            get {return _isDoorOpen;}
        }

        public bool IsRunning
        {
            get {return _isRunning;}
        }

        public Washer()
        {
            _isPowerOnOrOff = false;
            _isRunning = false;
            _isDoorOpen = false;
        }


        public void OpenClose()
        {
            _isRunning = !_isRunning;
            _isDoorOpen = false;
        }

        public void Wash(bool eco)
        {
            if (!_isDoorOpen && _isPowerOnOrOff )
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
           if (!_isDoorOpen && _isPowerOnOrOff)
            {
                Console.WriteLine("Starting to Fill");
            }
        }

        public void Spin()
        {
            if (!_isDoorOpen && _isPowerOnOrOff)
            {
                Console.WriteLine("Lets give it a Spin");
            }
        }

        public void PowerOnOff()
        {
            _isRunning = false;
            Console.WriteLine(_isPowerOnOrOff ? "powering off" : "Powering on");
            _isPowerOnOrOff = !_isPowerOnOrOff;
        }
       
    }
}
