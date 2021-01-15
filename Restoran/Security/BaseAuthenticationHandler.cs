using Restoran.Model;
using Restoran.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Restoran.Database;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Restoran.Security
{
    public class BaseAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisniciService _userService;
     
      string username;
        string password;
        public BaseAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisniciService userService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return  AuthenticateResult.Fail("Missing Authorization Header");
          
            Model.Korisnik user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                username = credentials[0];
                password = credentials[1];
                user = _userService.Autenticiraj(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }
            var claims = new List<Claim>();
            if (user != null)
            {
                Helper.Helper.KorisnickoImeLogirani = user.KorisnickoIme;

                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme));
                claims.Add(new Claim(ClaimTypes.Name, user.Ime));
                List<Model.KorisnikUloga> uloge = _userService.GetUloge(user.KorisnikId);
                foreach (var role in uloge)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Uloge.Naziv));
                }
            }
            else
            {
             
                return AuthenticateResult.Fail("Invalid Username or Password");

            }

           
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return  AuthenticateResult.Success(ticket);
        }

    }
}
