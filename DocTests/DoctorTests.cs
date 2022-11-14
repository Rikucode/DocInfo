using DomainLogic.IRepositories;
using DomainLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic;

namespace DocTests
{
    public class DoctorTests
    {
        private readonly Mock<IDoctorRepository> _doctorRepositoryMock;
        private readonly DoctorService _doctorService;
        public DoctorTests()
        {
            _doctorRepositoryMock = new Mock<IDoctorRepository>();
            _doctorService = new DoctorService(_doctorRepositoryMock.Object);
        }
        [Fact]
        public void AddNullToDoctor_ShouldFail()
        {
            var res = _doctorService.AddDoctor(null);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось добавить врача");
        }
        [Fact]
        public void DoctorNotFound_ShouldFail()
        {
            _doctorRepositoryMock.Setup(repository => repository.GetById(It.IsAny<int>()))
            .Returns(() => null);

            var res = _doctorService.GetDoctorById(231412341);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось найти врача с данным ID");
        }
        [Fact]
        public void DoctorsListNotFound_ShouldFail()
        {
            _doctorRepositoryMock.Setup(repository => repository.GetDoctorsBySpeciality(It.IsAny<int>()))
            .Returns(() => null);

            var res = _doctorService.GetDoctorsBySpeciality(0);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалочь найти список врачей с данной специализацией");
        }
    }
}
