namespace Actio.Common.Commands
{
    public class AutheticateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
