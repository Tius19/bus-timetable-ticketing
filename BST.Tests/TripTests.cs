using Microsoft.VisualStudio.TestTools.UnitTesting;
using BST.Services;
using BST.Models;
using System;

namespace BST_Test
{
    [TestClass]
    public class TripTests
    {
        private TripService tripService;

        [TestInitialize]
        public void Setup()
        {
            tripService = new TripService();
        }

        [TestMethod]
        public void GetAllTrips_ReturnsList()
        {
            var trips = tripService.GetAllTrips();

            Assert.IsNotNull(trips);
        }

        [TestMethod]
        public void AddTrip_ValidTrip_Executes()
        {
            Trip trip = new Trip
            {
                BusID = 1,
                FromLocation = "Port Louis",
                ToLocation = "Curepipe",
                Departure = DateTime.Now.AddHours(2),
                Arrival = DateTime.Now.AddHours(4),
                Price = 100
            };

            tripService.AddTrip(trip);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CancelTrip_ValidTrip_Executes()
        {
            tripService.CancelTrip(1);

            Assert.IsTrue(true);
        }

        
    }
}
