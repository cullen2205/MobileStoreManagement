using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWCFService.Models.Functions
{
    public class Hash
    {
        public static string CreateToken()
        {
            Guid g = Guid.NewGuid();
            string token = Convert.ToBase64String(g.ToByteArray());
            token = token.Replace("=", "");
            token = token.Replace("+", "");

            return token;
        }
    }
}