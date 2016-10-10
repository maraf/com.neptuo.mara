using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models.Timelining
{
    public class NodeDataService
    {
        public const string DataUri = "~/App_Data/Timeline.xml";

        private IEnumerable<NodeModel> models;

        public NodeDataService(string dataUri)
        {
            using (StreamReader reader = new StreamReader(dataUri))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(NodeList));
                models = (NodeList)serializer.Deserialize(reader);
            }
        }

        public IEnumerable<NodeModel> Get()
        {
            return models.OrderByDescending(n => n.When);
        }
    }
}