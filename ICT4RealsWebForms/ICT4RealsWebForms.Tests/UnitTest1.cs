using System;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.Remise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICT4RealsWebForms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rail rail = new Rail(1, true, false, 1);
            User user = new User(2323, "test", "test", 1);
            Tram tram = new Tram(1, "test", rail, user, 1, true);
            Assert.AreEqual(tram.Id, 1, "TramID");
            Assert.AreEqual(tram.Type, "test", "tramID");
            Assert.AreEqual(tram.Rail, rail, "tram rail");
            Assert.AreEqual(tram.Driver, user, "tram driver");
            Assert.AreEqual(tram.OnRail, true, "tram onrail");
            Assert.AreEqual(tram._Status, 1, "tram status");
        }
    }
}
