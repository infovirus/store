using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 23423-31231", "D. Knut", "Art of Programming",
                     "11111111111111111111", 7.19m),

            new Book(2, "ISBN 23423-31232", "M. Fowler", "Refactoring",
                     "2222222222222", 12.45m),

            new Book(3, "ISBN 23423-31233", "B. Kernighan, D. Ritchie", "C Programming Language",
                     "33333333333", 14.98m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetbyId(int id)
        {
            return books.Single(book => book.Id == id);
        }
    } 
}
