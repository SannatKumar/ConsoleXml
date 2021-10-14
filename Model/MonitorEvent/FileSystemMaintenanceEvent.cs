using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLEditing.Model.MonitorEvent
{
    public class FileSystemMaintenanceEvent : MonitorEvent
    {
        public FileSystemMaintenanceEvent(string EventName = "") : base(MonitorEventType.FileSystemMaintenanceEvent, EventName)
        {
        }
    }
}
