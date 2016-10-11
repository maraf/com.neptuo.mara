using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models.Books
{
    public class BookDataService
    {
        public const string DataUri = "~/App_Data/Books.xml";

        private IEnumerable<BookModel> models;

        public BookDataService(string dataUri)
        {
            using (StreamReader reader = new StreamReader(dataUri))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BookList));
                models = (BookList)serializer.Deserialize(reader);
            }
        }

        public IEnumerable<BookModel> Get()
        {
            return models.OrderByDescending(n => n.When);
        }
    }
}