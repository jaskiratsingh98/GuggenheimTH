using GuggenheimTakeHome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class TripTests
    {
        [TestMethod]
        public void TestCalculateTripCost()
        {
            DateTime dateTime = new DateTime(2020, 5, 1, 17, 30, 00);
            Trip trip = new Trip(2, 5, dateTime);
            var totalCost = trip.CalculateCost();

            Assert.AreEqual(9.75, totalCost);
        }
    }
}
