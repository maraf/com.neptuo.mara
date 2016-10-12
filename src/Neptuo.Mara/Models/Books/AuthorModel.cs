using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neptuo.Mara.Models.Books
{
    public class AuthorModel
    {
        public string FullName { get; private set; }
        public string Slug { get; private set; }

        public AuthorModel(string fullName)
        {
            FullName = fullName;
            Slug = fullName
                .Replace(".", "")
                .Replace(" ", "-")
                .ToLowerInvariant();
        }
    }
}