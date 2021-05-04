namespace ApothecaryManager.Api.Services
{
    public class AuthenticatedUserResponse
    {
        public int userId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}