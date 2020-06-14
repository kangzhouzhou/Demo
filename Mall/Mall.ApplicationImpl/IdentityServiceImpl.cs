using Mall.AggregateRoot;
using Mall.Application;
using Mall.Dto.Base;
using Mall.Dto.Identity;
using Mall.IEntity.Structure;
using Mall.Repository.Structure;
using Microsoft.Extensions.Logging;
using System;

namespace Mall.ApplicationImpl
{
    public class IdentityServiceImpl : IdentityService
    {
        public IdentityServiceImpl(ICustomerResponsitory customerResponsitory,ILogger<IdentityServiceImpl> logging)
        {
            _customerResponsitory = customerResponsitory;
            _logger = logging;
        }

        private readonly ICustomerResponsitory _customerResponsitory;

        private readonly ILogger<IdentityServiceImpl> _logger;

        public ResponseBody<string> Login(LoginPostBody requestBody)
        {
            CustomerAR customer = _customerResponsitory.GetByAccount(requestBody.Account);
            return null;
        }

        public ResponseBody<string> ThirdParty(ThirdPartyPostBody requestBody)
        {
            throw new NotImplementedException();
        }
    }
}
