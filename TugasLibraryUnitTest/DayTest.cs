using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class DayTest
    {
        private Day day;

        [SetUp]
        public void Init()
        {
            day = new Day();
        }

        [Test]
        public void NotValidDayTest() 
        {
            int input = 1;
            string expected = "Senin";
            string actual = day.NameOfDay(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidDayTest()
        {
            int input = 9;
            string expected = "";
            string actual = day.NameOfDay(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
