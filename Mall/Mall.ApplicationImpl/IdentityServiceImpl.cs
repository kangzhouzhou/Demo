using Mall.Aggregate.Structure.Aggregate;
using Mall.Aggregate.Structure.Entity;
using Mall.AppConfig;
using Mall.Application;
using Mall.Assembler;
using Mall.Dto.Base;
using Mall.Dto.Identity;
using Mall.Repository.Structure;
using Mall.Utility.Encryption;
using Mall.Utility.Token;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using System;

namespace Mall.ApplicationImpl
{
    public class IdentityServiceImpl : IdentityService
    {
        public IdentityServiceImpl(IdentityAssembler assmbler, ICustomerResponsitory customerResponsitory, ILogger<IdentityServiceImpl> logging, AppConfiguration configuration)
        {
            _assmbler = assmbler;
            _customerResponsitory = customerResponsitory;
             _logger = logging;
            _configuration = configuration;
        }

        private readonly IdentityAssembler _assmbler;

        private readonly ICustomerResponsitory _customerResponsitory;

        private readonly ILogger<IdentityServiceImpl> _logger;

        private readonly AppConfiguration _configuration;


        public ResponseBody<string> Login(LoginPostBody requestBody)
        {
            ResponseBody<string> responseBody = new ResponseBody<string>();
            CustomerAggregate customerAggregate = _customerResponsitory.GetByAccount(requestBody.Account);
            if (customerAggregate == null || !customerAggregate.IsVisible || customerAggregate.Password != MD5Utility.Encrypt32LowerCase(requestBody.Password))
            {
                responseBody.Err = "账号或密码错误";
                return responseBody;
            }

            if (!customerAggregate.IsEnable)
            {
                responseBody.Err = "账号已被禁用";
                return responseBody;
            }

            if (!customerAggregate.OrganizationIsEnable)
            {
                responseBody.Err = "机构已被禁用";
                return responseBody;
            }

            CustomerDto customer = new CustomerDto();
            customer.ClientType = Aggregate.Enums.ClientType.Account;
            customer.CustomerId = customerAggregate.Id;
            responseBody.Data = JWTUtility.JwtEncode(customer, _configuration.JwtSecret);
            return responseBody;
        }

        public ResponseBody<string> ThirdParty(ThirdPartyPostBody requestBody)
        {
            throw new NotImplementedException();
        }

    }
}
