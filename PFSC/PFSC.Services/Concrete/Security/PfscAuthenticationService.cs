using System;
using  System.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using PFSC.Entities.Entites;
using PFSC.Entities.PFSC_DBContext;
using PFSC.Models.Security;
using PFSC.Services.Abstract.Base;
using PFSC.Services.Abstract.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using PFSC.Models.Enums;

namespace PFSC.Services.Concrete.Security
{
    public class PfscAuthenticationService : BaseService, IPfscAuthenticationService
    {
        private readonly HttpContext _httpContext;
        public PfscAuthenticationService(PfscDbContext context, IHttpContextAccessor accessor) : base(context)
        {
            _httpContext = accessor.HttpContext;
        }

        public bool Login(LoginModel loginModel)
        {
            User user =
                _context.Users.Include(u => u.Role).FirstOrDefault(u => u.Email == loginModel.LoginName && u.Password == loginModel.Password);
            if (user != null)
            {
                Authenticate(user);
                return true;
            }
            return false;
        }

        public User Register(RegisterModel registerModel)
        {
            User user = _context.Users.FirstOrDefault(u => u.Email == registerModel.Email);
            if (user == null)
            {
                var newUser = new User
                {
                    Email = registerModel.Email,
                    FirstName = registerModel.FirstName,
                    LastName = registerModel.LastName,
                    Password = registerModel.Password,
                    Role = GetUserRole(PfscRoles.User)
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                Authenticate(newUser);
                return newUser;
            }
            return null;
        }

        public void Logout()
        {
            _httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private Role GetUserRole(PfscRoles role)
        {
            return _context.Roles.FirstOrDefault(r => r.Title == role.ToString());
        }

        private void Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Title)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            _httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
