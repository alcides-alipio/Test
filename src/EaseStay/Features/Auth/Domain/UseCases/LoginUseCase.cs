using EaseStay.Core;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Domain.UseCases
{
    internal class LoginUseCase
    {
        private readonly IUserRepository _repository;

        public LoginUseCase(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public User Execute(string email, string password, bool saveSession)
        {
            User user = _repository.GetByEmail(email);

            if (user == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return null;

            if (saveSession)
                Settings.SavePersistentSession(user.UUID);

            Settings.UserUUID = user.UUID;
            Settings.UserFirstName = user.FirstName;
            Settings.UserLastName = user.LastName;
            Settings.UserEmail = user.Email;

            return user;
        }
    }
}
