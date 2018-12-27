using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Entities.Entites;
using PFSC.Models.Security;
using PFSC.Models.User;

namespace PFSC.Services.Abstract.Security
{
    public interface IPfscAuthenticationService
    {
        UserModel GetCurrentUserInfo(string userName);
        UserModel UpdateUser(UserModel user, string userName);
        bool Login(LoginModel loginModel);
        User Register(RegisterModel registerModel);
        void Logout();
    }
}
