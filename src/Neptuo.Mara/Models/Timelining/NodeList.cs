using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models.Timelining
{
    [XmlRoot("Timeline")]//, Namespace = "http://schemas.neptuo.com/xsd/neptuo-website-blog.xsd")]
    public class NodeList : List<NodeModel>
    { }
}