using System;
using System.Collections.Generic;
using System.Text;

namespace DBS.Core
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        int Insert(Student obj);
        bool Update(Student obj);
        bool Delete(int studentID);

    }
}
