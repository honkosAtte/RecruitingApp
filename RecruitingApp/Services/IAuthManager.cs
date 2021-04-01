using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecruitingApp.Models;

namespace RecruitingApp.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginDTO userDTO);
        Task<string> CreateToken();
    }
}
