using System;
using ElevatorSample.Enum;
using ElevatorSample.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElevatorSample.Tests.ElevatorModelTests
{
    [TestClass]
    public class ElevatorModelTest
    {
        public ElevatorModel ElevatorModel { get; set; }
        [TestInitialize]
        public void SetUp()
        {
            ElevatorModel = new ElevatorModel();
        }

        [TestMethod]
        public void DefaultStatusShoudBeStopped()
        {
            Assert.AreEqual(ElevatorCurrentStatus.Stopped, ElevatorModel.ElevatorCurrentStatus);
        }

        [TestMethod]
        public void ShouldStartfromFloorOne()
        {
            Assert.AreEqual(1, ElevatorModel.StoppedOnFloor);
        }

        [TestMethod]
        public void ShouldNotHaveAnybodyInElevator()
        {
            Assert.AreEqual("0", ElevatorModel.NoOfPeopleInElevator);
        }

        [TestMethod]
        public void ShouldHaveTenFloors()
        {
            Assert.AreEqual(10, ElevatorModel.ElevatorFloors.Count);
        }
    }
}
