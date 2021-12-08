using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ApiIOTCafe.Entities;
using ApiIOTCafe.Model.User.Request;
using ApiIOTCafe.Model.User.Response;
using ApiIOTCafe.Service.User;
using ApiIOTCafe.Model.User.Entities;

namespace ApiIOTCafe.Controllers
{
    [Route("Services")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserServices _UserServices;

        public UserController(IUserServices UserServices)
        {
            _UserServices = UserServices;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest _Request)
        {

            ResponseEntities<LoginResponse> _Response = new ResponseEntities<LoginResponse>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _UserServices.Login(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpGet("GetAll")]
        public IActionResult UserGetAll()
        {

            ResponseEntities<List<UserEntities>> _Response = new ResponseEntities<List<UserEntities>>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = _UserServices.UserGetAll();

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(UserEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _UserServices.Insert(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UserEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _UserServices.Update(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(UserEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _UserServices.Delete(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

    }
}
