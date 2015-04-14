using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridges;
using Project2;

namespace AcceptanceTests
{
    [TestClass]
    public class ProjectTest
    {

        private Bridge bridge;

        public ProjectTest()
        {
            this.bridge = Driver.getBridge();
        }

        [TestMethod]
        public void TestAddNewNonExistingForum()
        {
            this.bridge.addForum("Sports", new Administrator("guy godes"));
        }

        [TestMethod]
        public void TestAddNewDuplicateForum()
        {
            this.bridge.addForum("Sports", new Administrator("guy godes"));
            this.bridge.addForum("Sports", new Administrator("john smith"));
        }
    }
}
