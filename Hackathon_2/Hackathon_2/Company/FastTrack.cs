using Hackathon_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Company
{
    /// <summary>
    /// Fasttrack class inheriting Analog interface
    /// </summary>
 # region implementation
    public class FastTrack : IAnalog
    {
        void IAnalog.MovingHand()
        {
            Console.WriteLine("Hour Hand,Minute Hand and Second Hand will be moving ");
        }

        void IAnalog.StrapColor()
        {
            Console.WriteLine("Black,Brown and Gold colors are available");
        }

        void IAnalog.StrapType()
        {
            Console.WriteLine("Available in Leather and Metal Straps");
        }

        void IAnalog.ManufacturingCountry()
        {
            Console.WriteLine("Made in Switzerland");
        }

        void IAnalog.Price_Range()
        {
            Console.WriteLine("Price ranges between 1500 to 10000");
        }

        public void Calender_Window()
        {
            Console.WriteLine("Calender Window available");
        }
    }
#endregion
}
