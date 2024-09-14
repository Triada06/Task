
using Domain.Entity;
using Repositories.Repositories;
using Repositories.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
    internal class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepo;

        public StudentService()
        {
            _studentRepo = new StudentRepository();
        }

        public List<Student> GetAll()
        {
            return _studentRepo.GetAll();
        }
    }
}
