using DomainLogic.Models;
using DomainLogic.IRepositories;
using DomainLogic.Services;

namespace DocTests
{
    public class UserTests
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly UserService _userService;
        public UserTests()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _userService = new UserService(_userRepositoryMock.Object);
        }

        [Fact]
        public void LoginIsEmptyOrNull_ShouldFail()
        {
            var res = _userService.GetUserByLogin(string.Empty);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "����� �� ��� ������");
        }

        [Fact]
        public void UserNotFound_ShouldFail()
        {
            _userRepositoryMock.Setup(repository => repository.GetByLogin(It.IsAny<string>()))
            .Returns(() => null);

            var res = _userService.GetUserByLogin("������ ���-�� ����� ������ � �� �������� � ������ ��� ������ ������ �� ����� ������ ����� ������� :)");

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "������������ � ����� ������� �� ������");
        }

        [Fact]
        public void UserDoesNotExist_ShouldFail()
        {
            _userRepositoryMock.Setup(repository => repository.IsExist(It.IsAny<User>()))
            .Returns(() => false);

            var res = _userService.IsExist(null);

            Assert.True(res.IsFailure);
            Assert.Equal(res.Error, "������ ������������ �� ����������");
        }
    }
}