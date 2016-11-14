using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppSimple.Models;
using NUnit.Framework;

namespace Models.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void PersonTest_FullName()
        {
            Person p = new Person();
            p.FirstName = "Ab";
            p.LastName = "Cd";
            Assert.AreEqual("Ab Cd", p.FullName);
        }

        [Test]
        public void PersonTest_FullName_FailingNoMore()
        {
            Person p = new Person();
            p.FirstName = "Ab";
            p.LastName = "Cd";
            Assert.AreEqual("Ab Cd", p.FullName);
        }

        [Test]
        public void PersonTest_MakeOlder()
        {
            Person p = new Person();
            p.MakeOlder(99);
            Assert.AreEqual(99, p.Age);
        }

        //build kickstarter
    }
}
