using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZOI.BAL.Services.Interface
{
    public interface IJWTToken
    {
        public string GetJWTToken(string emailId, IConfiguration config);
    }
}
