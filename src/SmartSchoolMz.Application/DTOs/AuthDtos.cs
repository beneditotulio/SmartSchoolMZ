namespace SmartSchoolMz.Application.DTOs;

public record LoginDto(
    string Email,
    string Password
);

public record UserDto(
    string Email,
    string Token
);
