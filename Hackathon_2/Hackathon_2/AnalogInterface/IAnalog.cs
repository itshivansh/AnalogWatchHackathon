using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    /// <summary>
    /// analog interface
    /// </summary>
    #region properties
    public interface IAnalog
      {
         void MovingHand();
         void StrapColor();
         void StrapType();
         void ManufacturingCountry();
         void Price_Range();
        void Calender_Window();
      }
    #endregion
}
