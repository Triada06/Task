
using Domain.Entity;
using Repositories.Repositories.Interfaces;
using Repositories.Repositories.Repositories;

namespace Repositories.Repositories
{
    public class BookRepository : IBookRepository, IBaseRepository<Book>
    {
        public void Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetBytId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
