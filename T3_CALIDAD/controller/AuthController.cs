using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceStack.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3_CALIDAD.controller
{
    [Authorize]
    public class AuthController : Controller
    {
        private readonly IAuthRepository context;
        private readonly IClaimService claim;
    }
    public AuthController(IAuthRepository context, IClaimService claim)
    {
        this.context = context;
        this.claim = claim;
    }
}
