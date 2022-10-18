using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class UserService
    {
       private readonly IDocRepository<User> _userRepository;
       public UserService(IDocRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public Result<User> GetUserByLogin(string login)
        {
            try
            {
                var result = _userRepository.GetByLogin(login);
                return result is null ? Result.Fail<User>("Пользователь с таким логином не найден") :
                    Result.Ok(result);
            }
            catch (Exception e)
            {
                return Result.Fail<User>("Error:" + e);
            }
        }
        public Result<User> CreateUser(User user)
        {
            try
            {
                var result = _userRepository.Create(user);
                return result is null ? Result.Fail<User>("Ошибка при создании пользователя") :
                    Result.Ok(result);
            }
            catch (Exception e)
            {
                return Result.Fail<User>("Error:" + e);
            }
        }
        public Result IsExist(User user)
        {
            try
            {
                var result = _userRepository.IsExist(user);
                return !result ? Result.Fail("Такой пользователь не существует") :
                    Result.Ok();
            }
            catch (Exception e)
            {
                return Result.Fail("Error:" + e);
            }
        }
    }

}
