using System.ComponentModel.DataAnnotations;

namespace LyuOAOpenId.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "您还没有输入帐号")]
        public string Username { get; set; }

        [Required(ErrorMessage = "您还没有输入密码")]
        public string Password { get; set; }
    }
}