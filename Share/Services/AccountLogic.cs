using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class AccountLogic : IAccountLogic
    {
        private readonly DataContext _context;
        private readonly TokenSettings _tokenSettings;
        public AccountLogic(DataContext context, IOptions<TokenSettings> tokenSettings)
        {
            _context = context;
            _tokenSettings = tokenSettings.Value;
        }

        public async Task<TokenResponseModel> LoginGoogleCustomer(LoginGoogleCustomer googleCustomer)
        {
            var customer = _context.Customers.Where(_ => _.Email == googleCustomer.Email).FirstOrDefault();
            if (customer == null)
            {
                // create new user and default roles
                await CreateNewCustomer(googleCustomer, customer);
            }

            return new TokenResponseModel
            {
                JwtToken = GetJWTAuthKey()
            };
        }

        public async Task CreateNewCustomer(LoginGoogleCustomer googleCustomer, Customer customer)
        {
            customer = new Customer
            {
                Email = googleCustomer.Email,
                FullName = googleCustomer.FirstName + " " + googleCustomer.LastName,
                CreatedDate = DateTime.Now,
                Status = true
            };
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }
        private string GetJWTAuthKey()
        {
            var securtityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.Key));

            var credentials = new SigningCredentials(securtityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _tokenSettings.Issuer,
                audience: _tokenSettings.Audience,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }
    }
}
