using DomainLogic.IRepositories;
using DomainLogic.Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic;

namespace DocTests
{
    public class AppointmentTests
    {
        private readonly Mock<IAppointmentRepository> _appointmentRepositoryMock;
        private readonly AppointmentService _appointmentService;
        public AppointmentTests()
        {
            _appointmentRepositoryMock = new Mock<IAppointmentRepository>();
            _appointmentService = new AppointmentService(_appointmentRepositoryMock.Object);
        }
        [Fact]
        public void AddNullAppointment_ShouldFail()
        {
            _appointmentRepositoryMock.Setup(repository => repository.AddAppointment(It.IsAny<AppointmentModel>()))
            .Returns(() => false);
            var res = _appointmentService.AddAppointment(null);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось сохранить запись на приём");
        }
        [Fact]
        public void FreeDatesNotFound_ShouldFail()
        {
            var res = _appointmentService.GetFreeDates(0);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось получить список свободных дат");
        }
    }
}
