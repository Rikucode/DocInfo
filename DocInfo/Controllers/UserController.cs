using DomainLogic.Services;
using DocInfo.Views;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DocInfo.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        public UserController(UserService service)
        {
            _service = service;
        }
        [HttpGet("login")]
        public ActionResult<UserSearchView> GetUserByLogin(string login)
        {
            if (login == string.Empty)
                return Problem(statusCode: 404, detail: "Не указан логин");
            var userRes = _service.GetUserByLogin(login);
            if (userRes.IsFailure)
                return Problem(statusCode: 404, detail: userRes.Error);

            return Ok(new UserSearchView
            {
                Id = userRes.Value.id,
                Login = userRes.Value.login
            });
        }
        [HttpGet("create_user")]
        public ActionResult<DomainLogic.User> CreateUser(UserModel user)
        {
            if (user.login == string.Empty)
                return Problem(statusCode: 502, detail: "Не указан логин");
            var userRes = _service.CreateUser(user);
            if (userRes.IsFailure)
                return Problem(statusCode: 502, detail: userRes.Error);

            return Ok(userRes);
        }
    }
}
