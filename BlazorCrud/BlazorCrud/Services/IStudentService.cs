using BlazorCrud.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        void InsertStudent(Student student);
        void DeleteStudent(int id);
    }
    
}
