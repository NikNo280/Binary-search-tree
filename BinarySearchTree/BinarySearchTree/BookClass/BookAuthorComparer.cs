using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace BookClass
{
    public class BookAuthorComparer : IComparer<Book>
    {
        public int Compare([AllowNull] Book book1, [AllowNull] Book book2)
        {
            if (book1 is null && book2 is null)
            {
                return 0;
            }
            else if (book1 is null)
            {
                return -1;
            }
            else if (book2 is null)
            {
                return 1;
            }

            if (book1.Author is null && book2.Author is null)
            {
                return 0;
            }
            else if (book1.Author is null && !(book2.Author is null))
            {
                return -1;
            }
            else if (!(book1.Author is null) && book2.Author is null)
            {
                return 1;
            }

            return book1.Author.CompareTo(book2.Author);
        }
    }
}

