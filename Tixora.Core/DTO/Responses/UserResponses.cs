using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tixora.Core.DTO.Responses
{
    public class UserResponse
    {
        public int UserID { get; set; }
        public string RoleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class LoginResponse
    {
        public string Token { get; set; }  // JWT token
        public UserResponse User { get; set; }
    }
}
