using Assignment.Data;
using Assignment.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public ActionResult<bool> Login(LoginVm obj)
        {
            bool exists = _dataContext.Users.Any(u => u.UserName == obj.UserName 
            && u.Password == obj.Password);

            return exists;      
        }
    }
}
