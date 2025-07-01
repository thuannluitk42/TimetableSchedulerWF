using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableSchedulerWF.Models
{
    public class Slot
    {
        public DayOfWeek Day { get; set; }
        public int Period { get; set; }
    }
}
