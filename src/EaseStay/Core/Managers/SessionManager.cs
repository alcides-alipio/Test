using EaseStay.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EaseStay.Core.Managers
{
    internal static class SessionManager
    {
        private static Dictionary<Guid, Session> _sessions = new Dictionary<Guid, Session>();

        public static Session CurrentSession { get; private set; }
        public static IReadOnlyCollection<Session> ActiveSessions => _sessions.Values;

        public static Session CreateSession(User user)
        {
            var existing = _sessions.Values
                .FirstOrDefault(s => s.UserUUID == user.UUID);

            if (existing != null)
                throw new ArgumentException($"Session for user '{user.UUID}' already exists.", nameof(user));

            var session = new Session
            {
                Id = Guid.NewGuid(),

                UserUUID = user.UUID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };

            _sessions[session.Id] = session;

            return session;
        }
    }
}
