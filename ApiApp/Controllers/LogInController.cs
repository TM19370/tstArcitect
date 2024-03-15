using ApiApp.Controllers.JSON;
using Microsoft.AspNetCore.Mvc;
using DataBaseClasses;
using static DataBaseClasses.DBInteract;

namespace ApiApp.Controllers
{
    public class LogInController : Controller
    {
        [HttpPost]
        [Route("login")]
        public IActionResult login([FromBody] LoginJSON loginData)
        {
            try
            {
                Account? account = db.accounts.Where(x => x.login == loginData.login).FirstOrDefault();
                if (account == null)
                    throw new Exception();
                if(account.password != loginData.password)
                    throw new Exception();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("неверные логин или пароль");
            }
            
        }
    }
}
