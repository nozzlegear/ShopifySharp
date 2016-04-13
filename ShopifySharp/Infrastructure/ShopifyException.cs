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
        
        /// <remarks>
        /// Dictionary is always initialized to ensure null reference errors won't be thrown when trying to check error messages.
        /// </remarks>
        public Dictionary<string, IEnumerable<string>> Errors { get; set; } = new Dictionary<string, IEnumerable<string>>();

        /// <summary>
        /// The raw, JSON-serialized error returned by Shopify.
        /// </summary>
        public string JsonError { get; set; }
        
        #endregion

        #region Constructors

        public ShopifyException() { }

        public ShopifyException(string message): base(message) { }

        public ShopifyException(HttpStatusCode httpStatusCode, Dictionary<string, IEnumerable<string>> errors, string message, string jsonError) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Errors = errors;
            JsonError = jsonError;
        }

        #endregion
    }
}
