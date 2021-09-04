using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public interface IUserService
    {
        Task<List<AppUser>> GetUsers();
    }
}
