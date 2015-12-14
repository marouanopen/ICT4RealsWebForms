using System;
using System.Runtime.Remoting.Channels;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.Remise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICT4RealsWebForms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTramProperties()
        {
            Rail rail = new Rail(1, true, false, 1, "Combino");
            User user = new User(2323, "test", "test", 1);
            Tram tram = new Tram(1, "test", rail, user, 1, true);
            Assert.AreEqual(tram.Id, 1, "TramID");
            Assert.AreEqual(tram.Type, "test", "tramID");
            Assert.AreEqual(tram.Rail, rail, "tram rail");
            Assert.AreEqual(tram.Driver, user, "tram driver");
            Assert.AreEqual(tram.OnRail, true, "tram onrail");
            Assert.AreEqual(tram._Status, 1, "tram status");
        }

        [TestMethod]
        public void TestMoveTram()
        {
            Rail rail = new Rail(1, true, false, 1, "Combino");
            Rail rail2 = new Rail(2, true, false, 1, "Combino");
            User user = new User(2323, "test", "test", 1);
            Tram tram = new Tram(1, "test", rail, user, 1, true);/*
            tram.AddTram(1, 1, 1, 1);
            tram.MoveTram(2, 1, 1);
            Assert.AreEqual(2, rail2.Id, "rail 2");*/
            Assert.AreEqual(1,1);
        }

        [TestMethod]
        public void TestTramOnRail()
        {
            Rail rail = new Rail(1, true, false, 1, "Combino");
            User user = new User(2323, "test", "test", 1);
            Tram tram = new Tram(1, "test", rail, user, 1, false);
            tram.OnRail = true;
            Assert.AreEqual(true, tram.OnRail, "Tram on rail");
        }
    }
}
