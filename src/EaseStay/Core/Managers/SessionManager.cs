using CredentialManagement;
using EaseStay.Core.Services;
using EaseStay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace EaseStay.Core.Managers
{
    internal static class SessionManager
    {
        private static User _currentUser = null;

        public static User CurrentUser { get => _currentUser; }

        public static void SetCurrentUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (_currentUser != null)
                throw new InvalidOperationException($"A session is already active for user '{_currentUser.Email}'.");

            _currentUser = user;
        }

        public static void ClearCurrentUser()
        {
            if (_currentUser == null)
                throw new InvalidOperationException("No active session to clear.");

            _currentUser = null;
        }

        public static bool HavePresistentUser()
        {
            var credential = new Credential { Target = "EaseStay.Session" };

            if (!credential.Exists())
                return false;

            credential.Load();

            if (string.IsNullOrWhiteSpace(credential.Username))
                return false;

            return true;
        }

        public static void SavePersistentUser()
        {
            var credential = new Credential
            {
                Target = "EaseStay.Session",
                Username = _currentUser.UUID.ToString(),
                PersistanceType = PersistanceType.LocalComputer
            };

            credential.Save();
        }

        public static void DeletePersistentUser()
        {
            var credential = new Credential { Target = "EaseStay.Session" };
            credential.Delete();
        }

        public static void LoadPresistentUser()
        {
            var credential = new Credential { Target = "EaseStay.Session" };

            if (!credential.Exists())
                throw new InvalidOperationException("No persisted session was found.");

            credential.Load();

            if (string.IsNullOrWhiteSpace(credential.Username))
                throw new InvalidOperationException("No persisted session was found.");

            var user = AuthService.GetUserByUUID(Guid.Parse(credential.Username));

            if (user == null)
                throw new InvalidOperationException($"No user was found with the stored UUID '{credential.Username}'.");

            SetCurrentUser(user);
        }
    }
}
