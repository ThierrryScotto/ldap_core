namespace ldap_core.Models
{
    public class AppUser : IAppUser
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
    }
}