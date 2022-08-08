using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_Server.Core.DTOs.CommandResult.Token
{
    public class GenerateTokenResult
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiryTime { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
