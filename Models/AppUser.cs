namespace ldap_core.Models
{
    public interface IAppUser
    {
        string Username { get; }
        string DisplayName { get; }
        string Email { get; }
        string[] Roles { get; }
    }
    public class AppUser : IAppUser
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
    }
}