using AutoMapper;
using NUnit.Framework;
using SchoolSystem.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests.Services
{
    [TestFixture]
    class StudentServiceTests
    {
        private IStudentService _service;
        private readonly IMapper _mapper;

        public StudentServiceTests()
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddMaps("SchoolSystem.Data");
            });
            _mapper = config.CreateMapper();
        }

        [Test, Category("Getting")]
        public async Task GetById_Returns_ID_One()
        {
            //_service = new StudentService(Data.SchoolSystemDbContext, _mapper);
        }
    }
}
