using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models.Timelining
{
    [XmlType("Node")]
    [XmlRoot("Node")]
    public class NodeModel
    {
        public DateTime When { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}