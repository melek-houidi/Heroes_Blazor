using BlazorCrud.Data;
using BlazorCrud.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<Student> _repository;
        private AppDbContext _appDbContext;
        public StudentService(IRepository<Student> repository , AppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }
        public void DeleteStudent(int id)
        {
            Student student = _appDbContext.Students.FirstOrDefault(c => c.StudentId.Equals(id));
            _repository.Remove(student);
            _repository.SaveChanges();
        }

        public List<Student> GetStudents() => _repository.GetAll();


        public void InsertStudent(Student student)
        {
            if (student.StudentId is 0) _repository.Insert(student);
            else _repository.Update(student);
        }
    }
}
