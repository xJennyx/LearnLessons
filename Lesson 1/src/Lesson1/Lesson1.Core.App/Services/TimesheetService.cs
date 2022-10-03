using Lesson1.Core.Domain.Models;
using System.Collections.Generic;

namespace Lesson1.Core.App.Services
{
    public class TimesheetService
    {
        public bool TrackTime(TimeLog timeLog)
        {
            Timesheets.TimeLogs.Add(timeLog);

            return true;
        }
    }

    public static class Timesheets
    {
        public static List<TimeLog> TimeLogs { get; set; } = new List<TimeLog>();
    }
}
