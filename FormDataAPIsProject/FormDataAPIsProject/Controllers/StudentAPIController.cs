using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormDataAPIsProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormDataAPIsProject.Controllers
{
    [Route("api/StudentAPI")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        /// <summary>
        /// this action will validate parameters and 
        /// if they are not valid then will send 400 Bad Request.
        /// Also, if we are receving empty string in any parameter then
        /// we do not send that parameter in response.
        /// </summary>
        /// <param name="details">contains student details</param>
        /// <returns>returns student information</returns>
        public IActionResult GetStudentDetailInReverse([FromForm]StudentsDetails details)
        {
            StudentsDetails students = new StudentsDetails();

            StudentService.StudentService stdService = new StudentService.StudentService();
            students = stdService.GetStudentInfoInReverse(details);

            return Ok(students);
        }
      
    }
}