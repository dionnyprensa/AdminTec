using AdminTec.Domain.Entities;

namespace AdminTec.Application.Interfaces
{
    public interface IUser : IAppService<User>
    {
        User SignIn(string username, string pass);
    }
}