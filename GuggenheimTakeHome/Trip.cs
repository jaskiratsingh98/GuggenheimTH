using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuggenheimTakeHome
{
    public class Trip
    {
        public Trip(int milesBelow6Mph, int minsAbove6Mph, DateTime dateTime)
        {
            _milesBelow6Mph = milesBelow6Mph;
            _minsAbove6Mph = minsAbove6Mph;
            _date = dateTime;
        }

        //TODO: Fix formula
        //TODO: Use const for .35
        public double CalculateCost()
        {
            return BaseFee + (.35 * (GetMilesUnits() + GetMinsUnits()));
        }

        private double GetMilesUnits()
        {
            return _milesBelow6Mph * MilesUnitFactor;
        }

        private double GetMinsUnits()
        {
            return _minsAbove6Mph * MinsUnitFactor;
        }

        private int _milesBelow6Mph;
        private int _minsAbove6Mph;
        private DateTime _date;
        private DateTime time;
        private double _total;

        private const double BaseFee = 3.0;
        private const double MilesUnitFactor = 0.2;
        private const int MinsUnitFactor = 60;
        private const double NightSurcharge = 0.5;
        private const double PeakHourSurcharge = 1.0;
        private const double NYStateTaxSurcharge = 0.5;

        private readonly TimeSpan NightSurchargeBegin = new TimeSpan(20, 0, 0);
        private readonly TimeSpan NightSurchargeEnd = new TimeSpan(6, 0, 0);
        private readonly TimeSpan PeakSurchargeBegin = new TimeSpan(16, 0, 0);
        private readonly TimeSpan PeakSurchargeEnd = new TimeSpan(20, 0, 0);
    }
}
