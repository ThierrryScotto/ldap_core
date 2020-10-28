using System;
using System.Security.Claims;
using System.Threading.Tasks;
using ldap_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ldap_core.Controllers
{
    [Route("v1")]
    public class AccountController : ControllerBase
    {
        private readonly Services.IAuthenticationService _authService;

        public AccountController(Services.IAuthenticationService authService)
        {
            _authService = authService;
        }

        public async Task<ActionResult<dynamic>> Autheticate([FromBody]LdapConfig model)
        {
            var user = _authService.Login(model.Username, model.Password);

            var claimsIdentity = new ClaimsIdentity(userClaims, _authService.GetType().Name);
            
            if (Array.Exists(user.Roles, s => s.Contains("aspnetcore.ldap")))
            {
                claimsIdentity.AddClaim(new Claim("aspnetcore.ldap.user", "true"));
            }   

            return new 
            {
                user = user,
                token = token
            };
        }
        
    }
}