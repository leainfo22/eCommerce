using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
namespace eCommerce.Infrastructure.Repositories;
internal class UserRepository : IUserRepository
{
    public async Task<ApplicationUser?> AddUser(ApplicationUser user)
    {
        //Generate a dump implementation
        user.UserID = Guid.NewGuid();
        return user;
    }

    public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
    {
        return new ApplicationUser()
        {
            UserID = Guid.NewGuid(),
            Email = email,
            Password = password,
            PersonName = "Leandro Vasquez",
            Gender = GenderOptions.Male.ToString()
        };
    }
}

