using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);
        public Task<int> GetNumberOfStudentsAsync();
        public Task<int> GetNumberOfWomanAsync();
        public Task<int> GetNumberOfMenAsync();
        public Task<List<Student>> GetAllTheStudentsBySchoolYearAsync(int schoolYears);

        public Task<int> GetNumberOfStudentByYearAsync(int year);
        public Task<int> GetNumberOfStudentByYearAndMonthAsync(int year, int month);

    }
}
