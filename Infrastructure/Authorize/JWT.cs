using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EnumType;
using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;

namespace Infrastructure.Authorize
{


    public class JWT
    {
        private static string Secret = "hekun";
        public static string Encode(string UserName,Guid Id,string UserRole)
        {
            string token = new JwtBuilder()
                .WithAlgorithm(new HMACSHA256Algorithm())
                .WithSecret(Secret)
                .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                .AddClaim("Name",UserName)
                .AddClaim("Id",Id)
                .AddClaim("Role",UserRole)
                .Build();
            return token;
        }
        public static bool Decode(string token,out string result)
        {
            try
            {
                result = new JwtBuilder()
                    .WithSecret(Secret)
                    .MustVerifySignature()
                    .Decode(token);
                
            }
            catch(TokenExpiredException)
            {
                result = null;
                return false;
            }
            catch(SignatureVerificationException)
            {
                result = null;
                return false;
            }
            return true;
        }
    }
}
