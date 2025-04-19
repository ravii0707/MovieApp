using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tixora.Core.DTO.Requests
{
    public class RegisterUserRequest
    {
        public string RoleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
    public class LoginUserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UpdateUserRequest
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
