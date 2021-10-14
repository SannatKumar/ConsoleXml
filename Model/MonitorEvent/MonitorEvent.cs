using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLEditing.Model.MonitorEvent
{
    public class MonitorEvent
    {
        [Flags]
        public enum MonitorEventType
        {
            DatabaseEvent,
            FileSystemEvent,
            HttpEvent,
            OutboundEmailEvent,
            FileSystemMaintenanceEvent
        }

        public MonitorEvent(MonitorEventType MonitorEventType, string EventName = "")
        {
            type = MonitorEventType;
            Name = EventName;
        }

       
        public string Name { get; set; }

        public MonitorEventType type { get; set; }

        public override string ToString()
        {
            return Name + ": " + type.ToString();
        }
    }
}
