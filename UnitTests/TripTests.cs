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
            // Test weekday peak cost
            DateTime dateTime = new DateTime(2020, 5, 1, 17, 30, 00);

            // Create a new trip, 2 miles travled below 6 mph, and 5 mins above 6 mph
            Trip trip = new Trip(2, 5, dateTime);
            var totalCost = trip.CalculateCost();

            Assert.AreEqual(9.75, totalCost);

            // Test weekday night cost
            dateTime = new DateTime(2020, 5, 1, 21, 30, 00);

            // Create a new trip, 2 miles travled below 6 mph, and 5 mins above 6 mph
            trip = new Trip(2, 5, dateTime);
            totalCost = trip.CalculateCost();

            Assert.AreEqual(9.25, totalCost);

            // Test weekend non night hours
            dateTime = new DateTime(2020, 5, 2, 17, 30, 00);

            // Create a new trip, 2 miles travled below 6 mph, and 5 mins above 6 mph
            trip = new Trip(2, 5, dateTime);
            totalCost = trip.CalculateCost();

            Assert.AreEqual(8.75, totalCost);


        }
    }
}
