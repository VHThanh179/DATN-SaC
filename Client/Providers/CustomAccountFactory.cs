using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Share.Models;
using Share.Services;

namespace Client.Providers
{
    public class CustomAccountFactory : AccountClaimsPrincipalFactory<RemoteUserAccount>
    {
        private readonly AppAuthClient _appAuthClient;
        public CustomAccountFactory(IAccessTokenProviderAccessor accessor,
            AppAuthClient appAuthClient
            ) : base(accessor)
        {
            _appAuthClient = appAuthClient;
        }

        public async override ValueTask<ClaimsPrincipal> CreateUserAsync(
            RemoteUserAccount account, RemoteAuthenticationUserOptions options)
        {
            var initialUser = await base.CreateUserAsync(account, options);
            try
            {
                if (initialUser.Identity.IsAuthenticated)
                {
                    var googleCustomer = new LoginGoogleCustomer
                    {
                        Email = initialUser.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault(),
                        FirstName = initialUser.Claims.Where(_ => _.Type == "given_name").Select(_ => _.Value).FirstOrDefault(),
                        LastName = initialUser.Claims.Where(_ => _.Type == "family_name").Select(_ => _.Value).FirstOrDefault()
                    };

                    var response = await _appAuthClient.LoginGoogleCustomer(googleCustomer);

                    ((ClaimsIdentity)initialUser.Identity).AddClaim(
                        new Claim("APIjwt", response.JwtToken)
                    );

                    ((ClaimsIdentity)initialUser.Identity).AddClaim(
                        new Claim("firstLogin", response.FirstLogin.ToString())
                    );
                }
            }
            catch
            {
                initialUser = new ClaimsPrincipal(new ClaimsIdentity());
            }

            return initialUser;
        }
    }
}
