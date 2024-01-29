namespace apiServer.Models.ForUser
{
    public class UserRequest
    {
        public string email { get; set; }
        public string password { get; set; }
        public People? people { get; set; }
    }
}