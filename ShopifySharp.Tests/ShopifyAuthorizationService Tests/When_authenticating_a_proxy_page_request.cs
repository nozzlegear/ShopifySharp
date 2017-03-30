using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAuthorizationService_Tests
{
    [Subject(typeof(AuthorizationService))]
    class When_authenticating_a_proxy_page_request
    {
        Establish context = () =>
        {
            //Configure querystring
            RequestQuerystring = new NameValueCollection();
            RequestQuerystring.Add("shop", "stages-test-shop-2.myshopify.com");
            RequestQuerystring.Add("path_prefix", "/apps/stages-order-tracker");
            RequestQuerystring.Add("timestamp", "1459781841");
            RequestQuerystring.Add("signature", "239813a42e1164a9f52e85b2119b752774fafb26d0f730359c86572e1791854a");
        };

        Because of = () =>
        {
            IsValid = AuthorizationService.IsAuthenticProxyRequest(RequestQuerystring, Utils.SecretKey);
        };

        It should_authenticate_a_proxy_page_request = () =>
        {
            IsValid.ShouldBeTrue();
        };

        Cleanup after = () =>
        {

        };

        static NameValueCollection RequestQuerystring = new NameValueCollection();

        static bool IsValid;
    }
}