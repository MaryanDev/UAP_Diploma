using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Entities.Entites;
using PFSC.Models.Security;

namespace PFSC.Services.Abstract.Security
{
    public interface IPfscAuthenticationService
    {
        bool Login(LoginModel loginModel);
        User Register(RegisterModel registerModel);
        void Logout();
    }
}
