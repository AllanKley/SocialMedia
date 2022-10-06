using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using System.Linq;

namespace Controllers
{
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public IConfiguration _configuration; //add

        public UserController(IConfiguration config)
        { //add
            _configuration = config;
        }


        [HttpGet]
        [Route("all")]
        public List<Model.User> getAll()
        {  
            var all = Model.User.GetAll();
            return all;
        }
    }
}