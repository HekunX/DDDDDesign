using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;

namespace Infrastructure.Authorize
{
    public class JWT
    {
        private static string Secret = "hekun";
        public static string Encode()
        {
            string token = new JwtBuilder()
                .WithAlgorithm(new HMACSHA256Algorithm())
                .WithSecret(Secret)
                .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                .Build();
            return token;
        }
        public static bool Decode(string token)
        {
            try
            {
                var json = new JwtBuilder()
                    .WithSecret(Secret)
                    .MustVerifySignature()
                    .Decode(token);
            }
            catch(TokenExpiredException)
            {
                return false;
            }
            catch(SignatureVerificationException)
            {
                return false;
            }
            return true;
        }
    }
}
