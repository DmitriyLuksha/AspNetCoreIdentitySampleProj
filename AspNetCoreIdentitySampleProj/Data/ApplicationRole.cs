﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentitySampleProj.Data
{
    public class ApplicationRole : IdentityRole
    {
        public string Custom { get; set; }
    }
}
