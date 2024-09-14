using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services.Models.Request
{
    public class AuthenticateUserByNameRequest
    {
        public string Username { get; set; }
        public string Pw { get; set; }
    }
}
