using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmiChoiceTravels.Models.ViewModel;
using EmiChoiceTravels.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmiChoiceTravels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountRepository _acc;
        public AccountController(AccountRepository account)
        {
            _acc = account;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Post([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string token = await _acc.LoginUser(model);
                if(token != null)
                {
                    return Ok(token);
                }
            }
            return BadRequest(ModelState);
        }
    }
}