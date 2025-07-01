using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableSchedulerWF.Models
{
    public class ScheduleEntry
    {
        public Class Class { get; set; }
        public Teacher Teacher { get; set; }
        public Room Room { get; set; }
        public DayOfWeek Day { get; set; }
        public int Period { get; set; }
    }
}
