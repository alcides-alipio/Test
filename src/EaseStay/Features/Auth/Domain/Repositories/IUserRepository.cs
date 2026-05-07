using EaseStay.Features.Auth.Domain.Entities;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Domain.Repositories
{
    internal interface IUserRepository
    {
        User GetByEmail(string email);
        void Add(User user);
        void Update(User user);
    }
}
