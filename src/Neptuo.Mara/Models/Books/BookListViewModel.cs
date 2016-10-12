using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neptuo.Mara.Models.Books
{
    public class BookListViewModel
    {
        public IEnumerable<BookModel> Books { get; private set; }
        public IEnumerable<AuthorModel> Authors { get; private set; }

        public BookListViewModel(IEnumerable<BookModel> books, IEnumerable<AuthorModel> authors)
        {
            Books = books;
            Authors = authors;
        }
    }
}