using EaseStay.Features.Auth.Domain.Entities;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Domain.Repositories
{
    internal interface IUserRepository
    {
        User GetByEmailAsync(string email);
        void AddAsync(User user);
    }
}
