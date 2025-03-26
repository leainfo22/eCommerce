namespace eCommerce.Core.DTO;

public record RegisterRequest(
     string? Email,
     string? Password,
     string? PersonName,
     GenderOptions Gender
    )
{
    //Parameterless contructor
    public RegisterRequest() : this(default,default, default, default) { }
}
  

