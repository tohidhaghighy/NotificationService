using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_Server.Core.Common
{
    public class BaseModel<T>
    {
        public T Id { get; set; }
    }
}
