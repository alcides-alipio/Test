using CredentialManagement;
using EaseStay.Core.Services;
using EaseStay.Model;
using System;

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
                throw new InvalidOperationException($"The user '{_currentUser.Email}' is already active.");

            _currentUser = user;
        }

        public static void ClearCurrentUser()
        {
            if (_currentUser == null)
                throw new InvalidOperationException("No active user to clear.");

            _currentUser = null;
        }

        public static bool HasPresistentUser()
        {
            var credential = new Credential { Target = "EaseStay.Session" };

            if (!credential.Exists())
                return false;

            credential.Load();

            if (string.IsNullOrWhiteSpace(credential.Username))
                return false;

            if (credential.Username == Guid.Empty.ToString())
                return false;

            return true;
        }

        public static void SavePersistentUser()
        {
            if (HasPresistentUser())
                throw new InvalidOperationException("A persisted session already exists");

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
            if (!HasPresistentUser())
                throw new InvalidOperationException("No persisted session to delete.");

            var credential = new Credential { Target = "EaseStay.Session" };
            credential.Delete();
        }

        public static void LoadPresistentUser()
        {
            if (!HasPresistentUser())
                throw new InvalidOperationException("No persisted session to load.");

            var credential = new Credential { Target = "EaseStay.Session" };
            credential.Load();

            var user = AuthService.GetUserByUUID(Guid.Parse(credential.Username));
            if (user == null)
                throw new InvalidOperationException($"No user was found with the stored UUID '{credential.Username}'.");

            SetCurrentUser(user);
        }
    }
}
