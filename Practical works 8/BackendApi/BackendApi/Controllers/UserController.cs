using Domain.Models;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BackendApi.Contracts.User;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _userService.GetById(id);
            var response = new GetUserResponse() {
               
                 IsDeleted= result.IsDeleted,
                RegDate = result.RegDate,
                Role = result.IdRole,               
                Login = result.UserLogin,              
                Password = result.UserPassword,
            };
            return Ok(response);
        }

        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        ///
        /// POST /Todo
        /// {
        /// "login" : "A4Tech Bloody B188",
        /// "password" : "!Pa$$word123@",
        /// "firstname" : "Иван",
        /// "lastname" : "Иванов",
        /// "middlename" : "Иванович"
        /// }
        ///
        /// </remarks>
        /// <param name="model">Пользователь</param>
        /// <returns></returns>
        // POST api/<UsersController>

        [HttpPost]
        public async Task<IActionResult> Add(CreateUserRequest request)
        {
            var userDto = new User() 
            {
            
                IsDeleted = request.IsDeleted,
                IdRole = request.Role,
                RegDate = request.RegDate,
                UserLogin = request.Login,
                UserPassword = request.Password,
            };

            await _userService.Create(userDto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(User user)
        {
            await _userService.Update(user);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Delete(id);
            return Ok();
        }
    }
}
