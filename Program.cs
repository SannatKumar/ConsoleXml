using System;
using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json;
using XMLEditing.Model;
using XMLEditing.Model.MonitorEvent;

namespace XMLEditing
{
    class Program
    {
        static void Main(string[] args)
        {
            MonitorEventDAO montitorEventDAO = new MonitorEventDAO();
            List<MonitorEvent> monitorEvents = montitorEventDAO.getAll();
            foreach (MonitorEvent monitorEvent in monitorEvents)
            {
                Console.WriteLine(monitorEvent);
            }
        }
    }
}
