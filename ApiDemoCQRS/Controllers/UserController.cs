using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using UserManagerment.Model;
using UserManagerment.Queries;
using ApiDemoCQRS.Services;

namespace ApiDemoCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _user;
        public UserController(IUserServices user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<List<UserModel>> Get()
        {
            return await _user.GetData();
        }
        [HttpGet("{id}")]
        public async Task<UserModel> Get(string id)
        {
            return await _user.GetDataById(id);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserModel user)
        {
            return Ok(await _user.CreateUser(user));

        }
    }
}
