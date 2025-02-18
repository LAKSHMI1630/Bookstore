using BookStrore.Models;

namespace BookStrore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBookById(int id)
        {
            Book b = DataSource().Where(x => x.BookId== id).FirstOrDefault();
            return b;
        }

        public List<Book> SearchBook(string title, string author)
        {

            List<Book> lst = DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
            return lst ;
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){BookId =1, Title="ASP.NET", Author="ABC"},
                new Book(){BookId =2, Title="MVC", Author="XYZ" },
                new Book(){BookId =3, Title="WEBAPI", Author="ABC" },
                new Book(){BookId =4, Title="C#", Author="XYZ"}
            };
        }
    }
}
