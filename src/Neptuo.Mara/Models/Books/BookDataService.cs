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
            return models.OrderByDescending(b => b.When);
        }

        public IEnumerable<AuthorModel> GetAuthors()
        {
            return models
                .Select(b => b.Author)
                .SelectMany(a => a.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                .Distinct()
                .Select(a => new AuthorModel(a))
                .OrderBy(a => a.FullName);
        }
    }
}