using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentitySampleProj.PasswordHasher
{
    public class CustomPasswordHasher<TUser> : PasswordHasher<TUser> where TUser : class
    {
        public override string HashPassword(TUser user, string password)
        {
            return password;
        }

        public override PasswordVerificationResult VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword)
        {
            if (hashedPassword == providedPassword)
            {
                return PasswordVerificationResult.Success;
            }

            return PasswordVerificationResult.Failed;
        }
    }
}
