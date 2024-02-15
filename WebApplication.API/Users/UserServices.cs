using FluentResults;

namespace WebApplication.API.Users
{
    public class UserServices
    {
        public Result<string> CreateUser(UserCreatedRequestDto userCreatedRequestDto)
        {
            return Result.Ok("user created");
        }
    }
}