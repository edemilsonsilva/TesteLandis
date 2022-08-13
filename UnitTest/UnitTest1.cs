using System;
using System.Security.Principal;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteLandis;
using TesteLandis.Models;

namespace UnitTest

{
    [TestClass]
    public class UnitTest1
    {
        MeterModel _meter = new MeterModel
        {
            SerialNumber = "SN123",
            SwitchState = EndpointModel.State.Armed,
            Id = MeterModel.Model.NSX1P3W,
            Number = 123,
            FirmwareVersion = "VER2.00"
        };

        [TestMethod]
        public void AddMeterEndPoint()
        {
            Endpoint endpoint = new Endpoint();
            endpoint.Insert(_meter);

            Assert.AreEqual(1, endpoint.ListAll().Count, 0, "Endpoint not inserted!");

        }

        [TestMethod]
        public void DuplicatedAddMeterEndPoint()
        {
            
            Endpoint endpoint = new Endpoint();
            endpoint.Insert(_meter);

            Assert.ThrowsException<System.InvalidOperationException>(() => endpoint.Insert(_meter));

        }

        [TestMethod]
        public void NullFindMeteterEndPoint()
        {
            Endpoint endpoint = new Endpoint();

            Assert.ThrowsException<System.InvalidOperationException>(() => endpoint.Find(_meter));


        }

        [TestMethod]
        public void EditMeteterEndPoint()
        {
            Endpoint endpoint = new Endpoint();
            endpoint.Insert(_meter);
            _meter.SwitchState = EndpointModel.State.Connected;
            endpoint.Edit(_meter);

            Assert.AreEqual(EndpointModel.State.Connected, endpoint.Find(_meter).SwitchState, "Endpoint not edited!");
        }
    }
}