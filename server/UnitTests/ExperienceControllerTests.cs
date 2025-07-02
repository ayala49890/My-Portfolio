using Microsoft.AspNetCore.Mvc;
using Portfolio.API.Controllers;
using Portfolio.API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class ExperienceControllerTests
    {
        [Fact]
        public void GetAll_ReturnsListOfExperience()
        {
            var controller = new ExperienceController();
            var result = controller.Get();
            Assert.IsType<List<ExperienceDto>>(result);
        }

        [Fact]
        public void GetAll_Returnsstring()
        {
            var controller = new ExperienceController();
            var result = controller.Get();
            Assert.IsType<string[]>(result);
        }

        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 1;

            //Act
            var controller = new ExperienceController();
            var result = controller.Get(id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
