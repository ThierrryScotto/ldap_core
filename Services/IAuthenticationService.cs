using ldap_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ldap_core.Services
{
    public interface IAuthenticationService
    {
        IAppUser Login(string username, string password);
    }
}