using System.ComponentModel.DataAnnotations;

namespace WebApplicationIdentity
{
    public class AddUserRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public string Email { get; set; }
        /*[Required]
        public string UserName { get; set; }
        [MinLength(3)]
        public string Password { get; set; }
        [Compare(nameof(Password))]//标注Password2必须等于Password
        public string Password2 { get; set; }
        [EmailAddress]
        public string Email { get; set; }*/

    }
}
