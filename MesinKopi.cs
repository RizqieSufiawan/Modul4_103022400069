using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400069
{
    internal class MesinKopi
    {
        private enum State
        {
            Off,
            Standby,
            Brewing,
            Maintenance
        }
        private State currentState;

        public MesinKopi()
        {
            currentState = State.Off;
            Console.WriteLine("Mesin kopi dalam keadaan Off.");
        }
        public void Standby()
        {
            if (currentState == State.Off)
            {
                currentState = State.Standby;
                Console.WriteLine("Mesin Off berubah menjadi Standby");
            }
            else if (currentState == State.Brewing)
            {
                currentState = State.Standby;
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
            }
            else if (currentState == State.Maintenance)
            {
                currentState = State.Standby;
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
            }
            else if (currentState == State.Standby)
            {
                Console.WriteLine("Mesin sudah Standby.");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void Brewing()
        {
            if (currentState == State.Standby)
            {
                currentState = State.Brewing;
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
            }
            else if (currentState == State.Brewing)
            {
                Console.WriteLine("Mesin sudah Brewing.");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void Maintenance()
        {
            if (currentState == State.Standby)
            {
                currentState = State.Maintenance;
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
            }
            else if (currentState == State.Maintenance)
            {
                Console.WriteLine("Mesin sudah Maintenance.");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void Off()
        {
            if (currentState == State.Standby)
            {
                currentState = State.Off;
                Console.WriteLine("Mesin Standby berubah menjadi Off");
            }
            else if (currentState == State.Off)
            {
                Console.WriteLine("Mesin sudah Off.");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }
}
