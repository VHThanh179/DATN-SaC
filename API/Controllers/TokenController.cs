using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Share.Interfaces;
using Microsoft.Extensions.Configuration;
using Share.Models.ViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public ICustomerSvc _customerSvc;
        public IConfiguration _configuration;
        public IActivity _activitySvc;

        public TokenController(ICustomerSvc customerSvc, IConfiguration configuration, IActivity activitySvc)
        {
            _customerSvc = customerSvc;
            _configuration = configuration;
            _activitySvc = activitySvc;
        }

        [HttpPost]
        public async Task<IEnumerable<ViewToken>> Post(ViewWebLogin viewWebLogin)
        {
            List<ViewToken> list = new List<ViewToken>();
            if (viewWebLogin != null && !string.IsNullOrEmpty(viewWebLogin.Email) && !string.IsNullOrEmpty(viewWebLogin.Password))
            {
                var cus = await _customerSvc.LoginAsync(viewWebLogin);
                if (cus != null)
                {
                    if (cus.Status)
                    {
                        var claims = new[]
                        {
                             new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                             new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                             new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

                             new Claim("Id", cus.CustomerId.ToString()),
                             new Claim("FullName", cus.FullName),
                             new Claim("Email", cus.Email)
                        };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"],
                            claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                        ViewToken viewToken = new ViewToken()
                        {
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                            customerID = cus.CustomerId,
                            customerName = cus.FullName
                        };

                        list.Add(viewToken);
                        await _activitySvc.SaveLogAsync(cus.Email);
                        return list;
                    }
                    else
                    {
                        return list;
                    }
                }
                else
                {
                    return list;
                }
            }
            return list;
        }
    }
}
