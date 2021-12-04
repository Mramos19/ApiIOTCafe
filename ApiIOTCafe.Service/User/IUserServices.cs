using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiIOTCafe.Model.User.Entities;
using ApiIOTCafe.Model.User.Response;
using ApiIOTCafe.Model.User.Request;

namespace ApiIOTCafe.Service.User
{
    public interface IUserServices
    {
        public Task<LoginResponse> Login(LoginRequest Request);
    }
}
