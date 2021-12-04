using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiIOTCafe.Model.User.Entities;
using ApiIOTCafe.Model.User.Request;
using ApiIOTCafe.Model.User.Response;

namespace ApiIOTCafe.Service.User
{
    public class UserServices : IUserServices
    {
        public async Task<LoginResponse> Login(LoginRequest Request)
        {

            LoginResponse Response = await Task.Factory.StartNew(() =>
            {
                return new LoginResponse()
                {
                    Token = "Token String",
                    UserInfo = new UserEntities()
                    {
                        UserId = 1,
                        FirstName = "Martin",
                        LastName = "Ramos",
                        UserName = "MRamos"
                    }
                };
            });

            return Response;

        }
    }
}
