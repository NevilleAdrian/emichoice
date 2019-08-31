using EmiChoiceTravels.Data;
using EmiChoiceTravels.Models;
using EmiChoiceTravels.Models.ViewModel;
using EmiChoiceTravels.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EmiChoiceTravels.Repository
{
    public class AccountRepository
    {
        private readonly AuthRepository _auth;
        private readonly ApplicationDbContext _ctx;
        public AccountRepository(AuthRepository auth,
            ApplicationDbContext context)
        {
            _auth = auth;
            _ctx = context;
        }

        public async Task<string> LoginUser(LoginViewModel model)
        {
            var loginPassWord = model.Password;
            var userPasswordHash = await _ctx.Users.Where(x => x.Email.Equals(model.Email, StringComparison.InvariantCultureIgnoreCase))
                                                .Select(x => x.PasswordHash).FirstOrDefaultAsync();
            if(userPasswordHash == null) { return null; }
            string userPassword = Encrypt.DecryptString(userPasswordHash);
            if(loginPassWord != userPassword)
            {
                return null;
            }
            else
            {
                return _auth.GetToken(model.Email);
            }
        }

        public async Task<string> RegisterUser(RegisterViewModel model)
        {
            string passwordHash = Encrypt.EncryptString(model.Password);
            ApplicationUser user = new ApplicationUser
            {
                Email = model.Email,
                FirstName = model.FirstName,
                SurName = model.SurName,
                PhoneNumber = model.PhoneNumber,
                PasswordHash = passwordHash
            };

            try
            {
                _ctx.Users.Add(user);
                await _ctx.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return await LoginUser(new LoginViewModel { Email = model.Email, Password = model.Password });
            
        }
    }
}
