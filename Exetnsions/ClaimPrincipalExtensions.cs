using System;
using System.Security.Claims;

namespace API.Exetnsions;

public static class ClaimPrincipalExtensions
{
    public static string GetMemberId(this ClaimsPrincipal user)
    {
        return user.FindFirstValue(ClaimTypes.NameIdentifier)
        ?? throw new Exception("Cannot get memberId from token");
    }
}
