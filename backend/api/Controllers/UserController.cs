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
using Model;

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

        //* ------------------------------------------------ Get All
        [HttpGet]
        [Route("all")]
        public List<Model.User> getAll()
        {  
            var all = Model.User.GetAll();
            return all;
        }

        //* ------------------------------------------------ Get All Active
        [HttpGet]
        [Route("active")]
        public List<Model.User> getAllActive()
        {  
            var all = Model.User.GetAllActive();
            return all;
        }

        //* ------------------------------------------------ Register User
        [HttpPost]
        [Route("register")]
        public string registerUser([FromBody] User user)
        {  
            user.Save();
            return "Usuário cadastrado com sucesso";
        }

        //* ------------------------------------------------ Update Info
        [HttpPost]
        [Route("update/info")]
        public string updateUser([FromBody] User user)
        {  
            user.Update();
            return "Usuário cadastrado com sucesso";
        }

        //* ------------------------------------------------ Update Theme
        [HttpPost]
        [Route("update/theme")]
        public string updateUserTheme([FromBody] User user)
        {  
            user.Update();
            return "Usuário cadastrado com sucesso";
        }

        //* ------------------------------------------------ Deactivate account
        [HttpPost]
        [Route("deativate")]
        public string deactivate([FromBody] User user)
        {  
            user.Activity();
            return "Usuário cadastrado com sucesso";
        }

        //* ------------------------------------------------ Find by Id
        [HttpPost]
        [Route("find/{id}")]
        public User find(int id)
        {  
            User user = Model.User.find(id);
            return user;
        }
        

    }
}
