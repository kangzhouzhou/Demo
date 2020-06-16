using Mall.Aggregate.Structure.Aggregate;
using Mall.Aggregate.Structure.Entity;
using Mall.Application;
using Mall.Assembler;
using Mall.Dto.Base;
using Mall.Dto.Identity;
using Mall.Repository.Structure;
using Mall.Utility.Token;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using System;

namespace Mall.ApplicationImpl
{
    public class IdentityServiceImpl : IdentityService
    {
        public IdentityServiceImpl(IdentityAssembler assmbler, ICustomerResponsitory  customerResponsitory ,ILogger<IdentityServiceImpl> logging)
        {
            _assmbler = assmbler;
            _customerResponsitory = customerResponsitory;
             _logger = logging;
        }

        private readonly IdentityAssembler _assmbler;

        private readonly ICustomerResponsitory _customerResponsitory;


        private readonly ILogger<IdentityServiceImpl> _logger;

        public ResponseBody<string> Login(LoginPostBody requestBody)
        {
            ResponseBody<string> responseBody = new ResponseBody<string>();
            CustomerAggregate customerAggregate = _customerResponsitory.GetByAccount(requestBody.Account);
            if (customerAggregate == null || customerAggregate.IsVisible)
            {
                responseBody.Err = "账号或密码错误";
                return responseBody;
            }

            if (!customerAggregate.IsEnable)
            {
                responseBody.Err = "账号已被禁用";
            }
            CustomerDto customer = new CustomerDto();
            customer.ClientType = Aggregate.Enums.ClientType.Account;
            customer.CustomerId = customerAggregate.Id;
            responseBody.Data = JWTUtility.JwtEncode(customer,null);
            return null;

        }

        public ResponseBody<string> ThirdParty(ThirdPartyPostBody requestBody)
        {
            throw new NotImplementedException();
        }

    }
}
