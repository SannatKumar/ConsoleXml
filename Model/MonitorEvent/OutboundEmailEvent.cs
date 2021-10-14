using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLEditing.Model.MonitorEvent
{
    public class OutboundEmailEvent : MonitorEvent
    {
        public OutboundEmailEvent(string EventName = "") : base(MonitorEventType.OutboundEmailEvent, EventName)
        {
        }
    }
}
