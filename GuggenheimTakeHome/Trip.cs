using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuggenheimTakeHome
{
    public class Trip
    {
        #region Constructor

        public Trip(int milesBelow6Mph, int minsAbove6Mph, DateTime dateTime)
        {
            MilesBelow6Mph = milesBelow6Mph;
            MinsAbove6Mph = minsAbove6Mph;
            Date = dateTime;
        }

        #endregion

        #region Properties

        public int MilesBelow6Mph { get; set; }

        public int MinsAbove6Mph { get; set; }

        public DateTime Date { get; set; }

        #endregion

        #region Functions

        public double CalculateCost()
        {
            return BaseFee + GetMinsPrice() + GetMilesPrice() + DetermineSurchargePrice() + NYStateTaxSurcharge;
        }

        private double GetMilesUnits()
        {
            return MilesBelow6Mph / MilesUnitFactor;
        }

        private double GetMilesPrice()
        {
            return UnitPrice * GetMilesUnits();
        }

        private double GetMinsUnits()
        {
            return MinsAbove6Mph * MinsUnitFactor;
        }

        private double GetMinsPrice()
        {
            return UnitPrice * MinsAbove6Mph;
        }

        private double DetermineSurchargePrice()
        {
            if(Date.DayOfWeek != DayOfWeek.Saturday && Date.DayOfWeek != DayOfWeek.Sunday)
            {
                if(Date.TimeOfDay >= PeakSurchargeBegin && Date.TimeOfDay < PeakSurchargeEnd)
                {
                    return PeakHourSurcharge;
                }
            }

            if (Date.TimeOfDay >= NightSurchargeBegin || Date.TimeOfDay < NightSurchargeEnd)
            {
                return NightSurcharge;
            }

            return 0;
        }

        #endregion

        #region Members

        private const double BaseFee = 3.0;
        private const double MilesUnitFactor = 0.2;
        private const int MinsUnitFactor = 60;
        private const double NightSurcharge = 0.5;
        private const double PeakHourSurcharge = 1.0;
        private const double NYStateTaxSurcharge = 0.5;
        private const double UnitPrice = 0.35;

        //private const int MinsToSeconds 

        private readonly TimeSpan NightSurchargeBegin = new TimeSpan(20, 0, 0);
        private readonly TimeSpan NightSurchargeEnd = new TimeSpan(6, 0, 0);
        private readonly TimeSpan PeakSurchargeBegin = new TimeSpan(16, 0, 0);
        private readonly TimeSpan PeakSurchargeEnd = new TimeSpan(20, 0, 0);

        #endregion
    }
}
