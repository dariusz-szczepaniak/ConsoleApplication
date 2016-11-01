using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppSimple.Models;

namespace Models.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PersonTest_FullName()
        {
            Person p = new Person();
            p.FirstName = "Ab";
            p.LastName = "Cd";
            Assert.AreEqual("Ab Cd", p.FullName);
        }
    }
}
