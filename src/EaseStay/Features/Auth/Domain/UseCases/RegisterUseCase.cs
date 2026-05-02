using EaseStay.Features.Auth.Domain.Repositories;
using EaseStay.Features.Auth.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace EaseStay.Features.Auth.Domain.UseCases
{
    internal class RegisterUseCase
    {
        private readonly IUserRepository _repository;

        public RegisterUseCase(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<User> Execute(string email, string firstName, string lastName, string password)
        {
            User user = await _repository.GetByEmailAsync(email);

            if (user != null)
                return null;

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            user = new User(email, false, firstName, lastName, passwordHash);

            await _repository.AddAsync(user);

            return user;
        }
    }
}
