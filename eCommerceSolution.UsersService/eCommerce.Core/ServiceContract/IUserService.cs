using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContract;

public interface IUserService
{
    /// <summary>
    /// Method to manage login a user
    /// </summary>
    /// <param name="loginRequest"></param>
    /// <returns></returns>
    Task<AuthenticationResponse?> Login(LoginRequest loginRequest);

    /// <summary>
    /// Method to manage register a user
    /// </summary>
    /// <param name="registerRequest"></param>
    /// <returns></returns>
    Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);


}
