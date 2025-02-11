using Kreata.Backend.Controllers.Base;
using Kreata.Backend.Repos;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    public partial class StudentController : BaseController<Student, StudentDto>
    {
        private IStudentRepo _studentRepo;
        public StudentController(StudentAssembler? assambler, IStudentRepo? repo) : base(assambler, repo)
        {
            _studentRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpGet("getstudentbyfullname")]
        public async Task<IActionResult> GetStudentByFullName([FromQuery] FullNameQueryDto fullNameDto)
        {
            return Ok(await _studentRepo.GetByNameAsync(fullNameDto.FirstName, fullNameDto.LastName));
        }


        [HttpGet("GetTheNumberOfStudents")]
        public async Task<IActionResult> GetNumberOfStudentsAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudentsAsync());
        }


        [HttpGet("GetTheNumberOfWoman")]
        public async Task<IActionResult> GetNumberOfWomanasync()
        {
            return Ok(await _studentRepo.GetNumberOfWomanAsync());
        }

        [HttpGet("GetNumberOfMen")]
        public async Task<IActionResult> GetNumberOfMenAsync()
        {
            return Ok(await _studentRepo.GetNumberOfMenAsync());
        }


        [HttpGet("NumberOfStudentByYear/{year}")]
        public async Task<IActionResult> GetNumberOfStudentByYearAsync(int year)
        {
            return Ok(await _studentRepo.GetNumberOfStudentByYearAsync(year));
        }

        [HttpGet("NumberOfStudentByYearAndMonth/{year}/{month}")]
        public async Task<IActionResult> GetNumberOfStudentByYearAndMonthAsync(int year, int month)
        {
            return Ok(await _studentRepo.GetNumberOfStudentByYearAndMonthAsync(year,month));
        }







    }
}
