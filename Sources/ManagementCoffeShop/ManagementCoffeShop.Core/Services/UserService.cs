using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models;
using ManagementCoffeShop.Core.Models.Entities;
using ManagementCoffeShop.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Services
{
    public class UserService : IUserService
    {

        private ICoffeShopContext _context;
        public UserService(ICoffeShopContext context)
        {
            _context = context;
        }

        // Create Function Code Login
        public LoginAttemptStatus LastLoginStatus { get; private set; } = LoginAttemptStatus.LoginSuccessful;

        public bool ValidateUser(string userName, string password)
        {
            LastLoginStatus = LoginAttemptStatus.LoginSuccessful;
            var user = GetUser(userName);
            if (user == null)
            {
              LastLoginStatus = LoginAttemptStatus.UserNotFound;
                return false;
            }

            var hash = GenerateHash.Instance.ComputeSha256Hash(password);
            var passwordMatches = hash == user.password;
            
            if(!passwordMatches)
            {
                LastLoginStatus = LoginAttemptStatus.PasswordIncorrect;
                return false;
            }

            return LastLoginStatus == LoginAttemptStatus.LoginSuccessful;
        }

        
        public Employe GetUser(string userName)
        {
            var user = _context.Employes.FirstOrDefault(x => x.userName == userName);
            return user;
        }


        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
