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
         abstract void MovingHand();
         abstract void StrapColor();
         abstract void StrapType();
         abstract void ManufacturingCountry();
         abstract void Price_Range();
         abstract void Calender_Window();
      }
    #endregion
}
