using AutoMapper;
using NUnit.Framework;
using SchoolSystem.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests.Services
{
    [TestFixture]
    class StudentServiceTests
    {
        private readonly StudentService studentService;

        public StudentServiceTests()
        {
            studentService = new StudentService();
        }

        [Test, Category("Getting")]
        public async Task GetById_Returns_ID_One()
        {
            var response = await studentService.GetStudent("/Options/1");
            Assert.AreEqual(true, response.IsSuccessStatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            //_service = new StudentService(Data.SchoolSystemDbContext, _mapper);
        }

       
    }
}
