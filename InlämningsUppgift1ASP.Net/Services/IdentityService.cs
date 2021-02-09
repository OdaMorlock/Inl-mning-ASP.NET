using InlämningsUppgift1ASP.Net.Data;
using InlämningsUppgift1ASP.Net.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlämningsUppgift1ASP.Net.Services
{
    public class IdentityService : IIdentityService
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        // Admin account : UserName = admin@domain.com Password = BytMig123!
        public async Task CreateDefaultAccountAndRolesAsync()
        {
            if (!_userManager.Users.Any())
            {
                // If no user exist make an admin account with UserName admin@domain.com
                var user = new ApplicationUser() { UserName = "admin@domain.com", Email = "admin@domain.com", FirstName = "Admin", LastName = "Account", DateOfBirth = DateTime.Now };

                // set the admin account password too BytMig123!
                var result = await _userManager.CreateAsync(user, "BytMig123!");
                if (result.Succeeded)
                {
                    // Create the basic roles Admin and User if none exist 
                    if (!_roleManager.Roles.Any())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                        await _roleManager.CreateAsync(new IdentityRole("User"));

                        //As Student and Teacher is needed in the assignment i will Create them at the same time as the two basic roles 

                        await _roleManager.CreateAsync(new IdentityRole("Student"));
                        await _roleManager.CreateAsync(new IdentityRole("Teacher"));

                    }

                    // set the admin account too role Admin
                    await _userManager.AddToRoleAsync(user, "Admin");

                }
            }

        }

        public async Task CreateNewRole(string RoleName)
        {
            await _roleManager.CreateAsync(new IdentityRole(RoleName));
        }

        public async Task<IdentityResult> CreateNewUserAsync(ApplicationUser User, string Password)
        {
            return await _userManager.CreateAsync(User, Password);
        }

        public async Task AssignUserToRoleAsync(ApplicationUser User, string RoleName)
        {
            await _userManager.AddToRoleAsync(User, RoleName);
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _userManager.Users;
        }

        public IEnumerable<IdentityRole> GetAllRoles()
        {
            return _roleManager.Roles;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersWithRolesAsync()
        {
            var users = GetAllUsers();
            var userlist = new List<UserViewModel>();

            foreach (var user in users)
            {

                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();

                userlist.Add(new UserViewModel {

                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    Email = user.Email,
                    Role = role

                });

            }
            return userlist;
        }
    }
}

