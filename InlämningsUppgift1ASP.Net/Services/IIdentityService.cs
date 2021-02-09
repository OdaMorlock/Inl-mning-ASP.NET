using InlämningsUppgift1ASP.Net.Data;
using InlämningsUppgift1ASP.Net.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlämningsUppgift1ASP.Net.Services
{
    public interface IIdentityService
    {
        Task CreateDefaultAccountAndRolesAsync();

        Task<IdentityResult> CreateNewUserAsync(ApplicationUser User, string Password);
        Task CreateNewRole(String RoleName);
        Task AssignUserToRoleAsync(ApplicationUser User,String RoleName);

        IEnumerable<ApplicationUser> GetAllUsers();
        IEnumerable<IdentityRole> GetAllRoles();

        Task<IEnumerable<UserViewModel>> GetAllUsersWithRolesAsync();


    }
}
