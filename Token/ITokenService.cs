using FirepitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirepitAPI.Token
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
