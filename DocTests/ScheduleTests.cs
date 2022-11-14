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
    public class ScheduleTests
    {
        private readonly Mock<IScheduleRepository> _scheduleRepositoryMock;
        private readonly ScheduleService _scheduleService;
        public ScheduleTests()
        {
            _scheduleRepositoryMock = new Mock<IScheduleRepository>();
            _scheduleService = new ScheduleService(_scheduleRepositoryMock.Object);
        }
        [Fact]
        public void ScheduleNotFound_ShouldFail()
        {
            _scheduleRepositoryMock.Setup(repository => repository.GetSchedule(It.IsAny<Doctor>(), It.IsAny<DateOnly>()))
            .Returns(() => false);
            DateOnly dateOnly = new DateOnly();
            var res = _scheduleService.GetSchedule(null, dateOnly);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось получить расписание для данного врача на выбранную дату");
        }
        [Fact]
        public void ScheduleNullAdded_ShouldFail()
        {
            var res = _scheduleService.AddSchedule(null);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось добавить расписание");
        }
        [Fact]
        public void ScheduleNullUpdated_ShouldFail()
        {
            var res = _scheduleService.UpdateSchedule(null, null);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "Не удалось обновить расписание");
        }
    }
}
