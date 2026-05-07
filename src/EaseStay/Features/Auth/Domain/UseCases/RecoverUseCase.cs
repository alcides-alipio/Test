using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Domain.UseCases
{
    internal class RecoverUseCase
    {
        private readonly IUserRepository _repository;

        public RecoverUseCase(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public User Execute(User user, string newPassword)
        {
            if (user == null)
                return null;

            if (newPassword == null)
                return null;

            if (_repository.GetByEmail(user.Email) == null)
                return null;

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            var newUser = new User(
                user.UUID,
                user.Email,
                user.EmailVerified,
                user.FirstName,
                user.LastName,
                passwordHash
            );

            _repository.Update(newUser);

            return newUser;
        }
    }
}
