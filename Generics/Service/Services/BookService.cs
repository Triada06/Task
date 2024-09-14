using Domain.Entity;
using Repositories.Repositories;
using Repositories.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BookService : IBookRepositoy
    {
        private readonly IBookRepository _bookRepo;

        public BookService()
        {
            _bookRepo = new BookRepository();
        }

        public List<Book> GetAll()
        {
            return _bookRepo.GetAll();
        }
    }
}
