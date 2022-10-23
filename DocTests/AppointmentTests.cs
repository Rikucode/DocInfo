using DomainLogic.IRepositories;
using DomainLogic.Services;
using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _appointmentRepositoryMock.Setup(repository => repository.AddAppointment(It.IsAny<Doctor>(), It.IsAny<DateOnly>()))
            .Returns(() => false);
            DateOnly dateOnly = new DateOnly();
            var res = _appointmentService.AddAppointment(null, dateOnly);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось сохранить запись на приём");
        }
        [Fact]
        public void FreeDatesNotFound_ShouldFail()
        {
            var res = _appointmentService.GetFreeDates(null);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось получить список свободных дат");
        }
    }
}
