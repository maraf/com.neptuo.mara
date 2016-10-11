using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models.Books
{
    [XmlType("Book")]
    [XmlRoot("Book")]
    public class BookModel
    {
        public DateTime When { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Image { get; set; }

        /// <summary>
        /// Stars: 5 (max) - 0 (min).
        /// </summary>
        public int Rating { get; set; }
    }
}