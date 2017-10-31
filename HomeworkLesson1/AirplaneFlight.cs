using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class AirplaneFlight
    {
        public Flight Flight;
        AirplaneRoute Airplaneroute;
        public bool IsTodayFlight()
        {
            return Airplaneroute.Date.Date == DateTime.Today;
        }
    }
}
