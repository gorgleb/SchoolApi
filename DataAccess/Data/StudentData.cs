using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class StudentData : IStudentData
    {
        private readonly ISqlDataAccess _db;
        public StudentData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task DeleteStudent(int id) => _db.SaveData("dbo.spStudent_Delete", new { Id = id });
        

        public async Task<StudentModel?> GetStudent(int id)
        {
            var results = await _db.LoadData<StudentModel, dynamic>(
                "dbo.spStudent_Get",
                new { Id = id });
            return results.FirstOrDefault();

        }

        public Task<IEnumerable<StudentModel>> GetStudents()=> _db.LoadData<StudentModel, dynamic>("dbo.spStudent_GetAll", new { });

        public Task InsertStudent(StudentModel student) => _db.SaveData("dbo.spStudent_Insert", new { student.FirstName, student.LastName });

        public Task UpdateStudent(StudentModel student) => _db.SaveData("dbo.spStudent_Update", student);

        public Task<IEnumerable<StudentModel>> ChooseTheExcellentStudents() => _db.LoadData<StudentModel, dynamic>("dbo.spStudent_ChooseTheExcellentStudents", new {});
        public Task<IEnumerable<StudentModel>> SelectTheLaggards () => _db.LoadData<StudentModel, dynamic>("dbo.spStudent_SelectTheLaggards", new { });

    }
}
