using EaseStay.Features.Auth.Domain.Entities;
using System;

namespace EaseStay.Features.Auth.Domain.Repositories
{
    internal interface IUserRepository
    {
        User GetByEmail(string uuid);
        User GetByUUID(Guid email);
        void Add(User user);
        void Update(User user);
    }
}
