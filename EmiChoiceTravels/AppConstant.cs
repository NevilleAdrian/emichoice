﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmiChoiceTravels
{
    public class AppConstant
    {
        public const string PasswordHash = "EncryptionParams:PasswordHash";
        public const string Salt = "EncryptionParams:SaltKey";
        public const string ViKey = "EncryptionParams:VIKey";
        public const string Secret = "JwtTokens:Secret";
        public const string Issuer = "JwtTokens:Issuer";
        public const string Audience = "JwtTokens:Audience";
        public const string UserEmail = "nwisuchisom@gmail.com";
    }
}
