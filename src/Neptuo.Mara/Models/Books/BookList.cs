using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models.Books
{
    [XmlRoot("Books")]
    public class BookList : List<BookModel>
    { }
}