using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class CommonResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }

    public class CommonResponse<T>: CommonResponse
    {
        public T Data { get; set; }
    }
}
