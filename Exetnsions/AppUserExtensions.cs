using System;
using API.DTOs;
using API.Entities;
using API.Interfaces;

namespace API.Exetnsions;

public static class AppUserExtensions
{
    public static async Task<UserDto> ToDto(this AppUser user, iTokenService tokenService)
    {
        return new UserDto
        {
            Id = user.Id,
            DisplayName = user.DisplayName,
            Email = user.Email!,
            ImageUrl = user.ImageUrl,
            Token = await tokenService.CreateToken(user)
        };
    }
}
