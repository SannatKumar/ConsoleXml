using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using static XMLEditing.Model.MonitorEvent.MonitorEvent;

namespace XMLEditing.Model.MonitorEvent
{
    public class MonitorEventDAO
    {
        public List<MonitorEvent> getAll()
        {
            List<MonitorEvent> monitorEvents = new List<MonitorEvent>();
            XmlDB db = XmlDB.Instance;
            XmlNode root = XmlDB.Instance.XmlDoc.SelectSingleNode("ActiveCMSMonitor");
            XmlNodeList xmlMonitorEvents = root.SelectNodes("MonitorEvent");

            foreach (XmlNode xmlMonitorEvent in xmlMonitorEvents)
            {
                string name = "";
                string monitorEventType = "";
                foreach (XmlAttribute attribute in xmlMonitorEvent.Attributes)
                {
                    
                    if (attribute.Name.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    {
                        name = attribute.Value;
                    }
                    else if (attribute.Name.Equals("xsi:type", StringComparison.OrdinalIgnoreCase))
                    {
                        monitorEventType = attribute.Value;
                    }
                }

                if (monitorEventType.Equals(MonitorEventType.DatabaseEvent.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    monitorEvents.Add(new DatabaseEvent(name));
                }
                else if (monitorEventType.Equals(MonitorEventType.FileSystemEvent.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    monitorEvents.Add(new FileSystemEvent(name));
                }
                else if (monitorEventType.Equals(MonitorEventType.HttpEvent.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    monitorEvents.Add(new HttpEvent(name));
                }
                else if (monitorEventType.Equals(MonitorEventType.OutboundEmailEvent.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    monitorEvents.Add(new OutboundEmailEvent(name));
                }
                else if (monitorEventType.Equals(MonitorEventType.FileSystemMaintenanceEvent.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    monitorEvents.Add(new FileSystemMaintenanceEvent(name));
                }
            }

            return monitorEvents;
        }
    }
}
