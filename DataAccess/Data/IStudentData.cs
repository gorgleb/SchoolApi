using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;  

public interface IStudentData
{
    Task DeleteStudent(int id);
    Task<StudentModel?> GetStudent(int id);
    Task<IEnumerable<StudentModel>> GetStudents();
    Task InsertStudent(StudentModel student);
    Task UpdateStudent(StudentModel student);
    Task<IEnumerable<StudentModel>> ChooseTheExcellentStudents();
    Task<IEnumerable<StudentModel>> SelectTheLaggards();



}
