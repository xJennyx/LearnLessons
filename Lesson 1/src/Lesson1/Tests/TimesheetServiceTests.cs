using Lesson1.Core.App.Services;
using Lesson1.Core.Domain.Models;
using NUnit.Framework;
using System;

namespace Tests
{
    class TimesheetServiceTests
    {
        [Test]
        public void TrackTime_ShouldReturnTrue()
        {
            // arrange
            var timeLog = new TimeLog
            {
                Date = new DateTime(),
                WorkingHours = 1,
                LastName = ""
            };

            var service = new TimesheetService();

            // act
            var result = service.TrackTime(timeLog);

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TrackTime_ShouldReturnFalse()
        {
            // arrange
            var period = new DateTime();
            var workingTimeHours = 1;
            var lastName = "";

            var timeLog = new TimeLog
            {
                Date = new DateTime(),
                WorkingHours = 1,
                LastName = ""
            };

            var service = new TimesheetService();

            // act
            var result = service.TrackTime(timeLog);

            // assert
            Assert.IsFalse(result);
        }
    }
}
