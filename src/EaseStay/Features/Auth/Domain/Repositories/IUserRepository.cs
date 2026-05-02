using EaseStay.Features.Auth.Domain.Entities;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Domain.Repositories
{
    internal interface IUserRepository
    {
        Task<User> GetByEmailAsync(string email);
        Task AddAsync(User user);
    }
}
