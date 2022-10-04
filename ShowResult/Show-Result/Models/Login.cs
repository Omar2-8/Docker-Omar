namespace Show_Result.Models
{
    public class Login
    {
        public decimal LoginId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
