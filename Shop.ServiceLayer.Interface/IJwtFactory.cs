﻿using System.Security.Claims;
using System.Threading.Tasks;

namespace Shop.ServiceLayer.Interface
{
    public interface IJwtFactory
    {
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
    }
}
