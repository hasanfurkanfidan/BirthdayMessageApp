using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public class UserManager : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        public UserManager(UserManager<AppUser>userManager)
        {
            _userManager = userManager;
        }
        public async Task<List<AppUser>> GetUsers()
        {
            return await _userManager.Users.Where(p => p.BirthDate.Date == DateTime.Today).ToListAsync();
        }
    }
}
