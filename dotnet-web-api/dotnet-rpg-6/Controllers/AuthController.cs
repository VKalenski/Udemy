#region Usings
using dotnet_rpg.Dtos.User;
using dotnet_rpg.Services.AuthRepository;
#endregion

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        #region Fields
        private readonly IAuthRepository _authRepo;
        #endregion

        #region Ctor
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        #endregion

        #region POST
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        #endregion
    }
}
