using BookStrore.Repository;
using Microsoft.AspNetCore.Mvc;
using BookStrore.Models;


namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _repo;

        public BookController()
        {
            _repo = new BookRepository();
          
        }
        public ViewResult GetAllBooks ()
        {
            var data = _repo.GetAllBooks();
            return View(data);
        }

        public Book GetBook(int id)
        {
            return _repo.GetBookById(id);
        }

        public List<Book> SearchBook(string bookname, string author)
        {
            return _repo.SearchBook(bookname, author);
        }
    }
}
