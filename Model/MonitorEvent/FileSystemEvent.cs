using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLEditing.Model.MonitorEvent
{
    class FileSystemEvent : MonitorEvent
    {
        public FileSystemEvent(string EventName = "") : base(MonitorEventType.FileSystemEvent, EventName)
        {
        }
    }
}
