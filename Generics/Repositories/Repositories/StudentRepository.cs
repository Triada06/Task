

using Domain.Entity;
using Repositories.Repositories.Interfaces;
using Repositories.Repositories.Repositories;

namespace Repositories.Repositories
{
    public class StudentRepository : IBaseRepository<Student>, IStudentRepository
    {
        public void Create(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetBytId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
