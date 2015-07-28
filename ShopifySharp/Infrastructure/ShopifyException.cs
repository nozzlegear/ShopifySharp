using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyException : ApplicationException
    {
        #region Public properties

        public HttpStatusCode HttpStatusCode { get; set; }

        public ShopifyError ShopifyError { get; set; }

        #endregion

        #region Constructors

        public ShopifyException() { }

        public ShopifyException(string message): base(message) { }

        public ShopifyException(HttpStatusCode httpStatusCode, ShopifyError shopifyError, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            ShopifyError = shopifyError;
        }

        #endregion
    }
}
