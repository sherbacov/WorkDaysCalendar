using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkDaysCalendar;

namespace WorkDaysCalendarTestProject
{
    [TestClass]
    public class Year2011Test
    {
        [TestMethod]
        public void CheckOlderYear()
        {
            Assert.IsTrue( WorkCalendar.IsWorkingDay(new DateTime(2000, 01, 01)) );
        }

        [TestMethod]
        public void CheckNextYear()
        {
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2050, 01, 01)));
        }

        [TestMethod]
        public void Check2011Year()
        {
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 01)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 02)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 03)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 04)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 05)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 06)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 07)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 08)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 09)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 10)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 11)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 12)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 13)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 14)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 15)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 16)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 17)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 18)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 19)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 20)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 21)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 22)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 23)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 24)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 25)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 26)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 27)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 28)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 29)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 30)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 01, 31)));
            
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 01)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 02)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 03)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 04)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 05)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 06)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 07)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 08)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 09)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 10)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 11)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 12)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 13)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 14)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 15)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 16)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 17)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 18)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 19)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 20)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 21)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 22)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 23)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 24)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 25)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 26)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 27)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 02, 28)));

            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 01)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 02)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 03)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 04)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 05)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 06)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 07)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 08)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 09)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 10)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 11)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 12)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 13)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 14)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 15)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 16)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 17)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 18)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 19)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 20)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 21)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 22)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 23)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 24)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 25)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 26)));
            Assert.IsFalse(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 27)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 28)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 29)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 30)));
            Assert.IsTrue(WorkCalendar.IsWorkingDay(new DateTime(2011, 03, 31)));

        }





    }
}
