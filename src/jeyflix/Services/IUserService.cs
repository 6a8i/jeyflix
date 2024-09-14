using jeyflix.Services.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services
{
    public interface IUserService
    {
        Task AuthenticateByNameAsync(AuthenticateUserByNameRequest request);
    }
}
