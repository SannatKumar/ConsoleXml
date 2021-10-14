using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLEditing.Model.MonitorEvent
{
    public class HttpEvent : MonitorEvent
    {
        public HttpEvent(string EventName = "") : base(MonitorEventType.HttpEvent, EventName)
        {
        }
    }
}
