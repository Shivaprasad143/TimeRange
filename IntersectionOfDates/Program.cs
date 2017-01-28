using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfDates
{
   class TimeRange
        {
            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }

            public TimeRange(DateTime start, DateTime end)
            {
                this.StartDate = start;
                this.EndDate = end;
            }

            public TimeRange()
            {

            }
        }


    }


