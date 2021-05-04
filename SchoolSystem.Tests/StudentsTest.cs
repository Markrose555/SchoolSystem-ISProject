using Newtonsoft.Json;
using NUnit.Framework;
using SchoolSystem.Data.Entities;
using SchoolSystem.Tests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests
{
    [TestFixture]
    class StudentsTest
    {
        private readonly StudentService studentService;

        public StudentsTest()
        {
            studentService = new StudentService();
        }


        [Test]
        public async Task ShouldReturnAllStudents()
        {
            var response = await studentService.GetStudent();
            Assert.AreEqual(true, response.IsSuccessStatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            //var studentResponse = JsonConvert.DeserializeObject<List<Student>>(await response.Content.ReadAsStringAsync());
        }
    }
}
