using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLEditing.Model.MonitorEvent
{
    public class DatabaseEvent : MonitorEvent
    {
        public DatabaseEvent(string EventName = "") : base(MonitorEventType.DatabaseEvent, EventName)
        {

        }
    }
}
