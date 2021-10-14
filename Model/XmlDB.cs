using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLEditing.Model
{
    public sealed class XmlDB
    {
        private readonly static string XMLPath = @"D:\Aventra_task\conf - examples.xml";
        private readonly static XmlDB _instance = new XmlDB();


        public XmlDocument XmlDoc { get; set; }

        private XmlDB()
        {
            XmlDoc = new XmlDocument();
            XmlDoc.Load(XMLPath);
        }

        public static XmlDB Instance
        {
            get
            {
                return _instance;
            }
             
        }
    }
}
