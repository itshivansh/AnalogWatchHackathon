using Hackathon_2.Company;
using Hackathon_2.Models;
using System;

namespace Hackathon_2
{
    class Program
    {
        /// <summary>
        /// Final Display
        /// </summary>
# region start
        static void Main(string[] args)
        {
            Console.Title = "Analog Watches";
            Console.WriteLine("Welcome\n\nSelect...Which company would you preffer?\na. Titan\nb. FastTrack\nc. Timex\n");
            string str = Console.ReadLine().ToLower();
            if (str == "a")
            {
                 IAnalog titan = new Titan();
                // Titan titan = new Titan();
                Console.WriteLine("Titan_analog_Watch");
                 titan.MovingHand();
                 titan.StrapColor();
                 titan.StrapType();
                 titan.ManufacturingCountry();
                 titan.Price_Range();
                titan.Calender_Window();
            }else if (str == "b")
            {
                IAnalog fasttrack = new FastTrack();
                Console.WriteLine("Fasttrack_analog_Watch");
                fasttrack.MovingHand();
                fasttrack.StrapColor();
                fasttrack.StrapType();
                fasttrack.ManufacturingCountry();
                fasttrack.Price_Range();
                fasttrack.Calender_Window();
            }else if (str == "c")
            {
                IAnalog timex = new Timex();
                Console.WriteLine("Timex_analog_Watch");
                timex.MovingHand();
                timex.StrapColor();
                timex.StrapType();
                timex.ManufacturingCountry();
                timex.Price_Range();
                timex.Calender_Window();
            }
            else
            {
                Console.WriteLine("Thanks for visiting us.Invalid Choice");
            }
        }
    }
    #endregion
}
