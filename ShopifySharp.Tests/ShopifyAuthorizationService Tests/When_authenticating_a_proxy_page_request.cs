using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAuthorizationService_Tests
{
    [Subject(typeof(ShopifyAuthorizationService))]
    class When_authenticating_a_proxy_page_request
    {
        Establish context = () =>
        {
            //Configure querystring
            RequestQuerystring = new NameValueCollection();
            RequestQuerystring.Add("shop", "iron-stages-beta-test-shop.myshopify.com");
            RequestQuerystring.Add("path_prefix", "%2fapps%2fauntiedot-proxy-page-3");
            RequestQuerystring.Add("timestamp", "1447706366");
            RequestQuerystring.Add("signature", "8b0062c022124d3c27c459fda841852d24a4424ee81612ee0fabdba1880d3150");            
        };

        Because of = () =>
        {
            IsValid = ShopifyAuthorizationService.IsAuthenticProxyRequest(RequestQuerystring, "This-Is-A-Test-Secret-Key");
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
