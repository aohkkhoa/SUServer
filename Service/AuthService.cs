using Microsoft.AspNetCore.Identity;
using SUServer.DTO;

namespace SUServer.Service
{
    public class AuthService
    {
        private readonly IConfiguration _configuration;
        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //public async Task<(int, string)> Registeration(RegistrationDTO model, string role)
        //{
        //    var userExists = await userManager.FindByNameAsync(model.Username);
        //    if (userExists != null)
        //        return (0, "User already exists");

        //    ApplicationUser user = new ApplicationUser()
        //    {
        //        Email = model.Email,
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = model.Username,
        //        Name = model.Name
        //    };
        //    var createUserResult = await userManager.CreateAsync(user, model.Password);
        //    if (!createUserResult.Succeeded)
        //        return (0, "User creation failed! Please check user details and try again.");

        //    if (!await roleManager.RoleExistsAsync(role))
        //        await roleManager.CreateAsync(new IdentityRole(role));

        //    userManager.AddToRoleAsync(user, role);

        //    return (1, "User created successfully!");
        //}
    }
}
