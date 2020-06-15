using Mall.Aggregate.Structure.Entity;
using Mall.Application;
using Mall.Assembler;
using Mall.Dto.Base;
using Mall.Dto.Identity;
using Mall.Entity.Structure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using System;

namespace Mall.ApplicationImpl
{
    public class IdentityServiceImpl : IdentityService
    {
        public IdentityServiceImpl(IdentityAssembler assmbler, IAuthenticationService  authenticationService ,ILogger<IdentityServiceImpl> logging)
        {
            _authenticationService = authenticationService;
            _logger = logging;
        }

        private readonly IdentityAssembler _assembler;

        private readonly IAuthenticationService _authenticationService;

        private readonly ILogger<IdentityServiceImpl> _logger;

        public ResponseBody<string> Login(LoginPostBody requestBody)
        {
            throw new NotImplementedException();
        }

        public ResponseBody<string> ThirdParty(ThirdPartyPostBody requestBody)
        {
            throw new NotImplementedException();
        }

    }
}
