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
    class When_authenticating_a_request
    {
        Establish context = () =>
        {
            //Configure querystring
            RequestQuerystring = new NameValueCollection();
            RequestQuerystring.Add("hmac", "134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746");
            RequestQuerystring.Add("shop", "stages-test-shop-2.myshopify.com");
            RequestQuerystring.Add("signature", "f477a85f3ed6027735589159f9da74da");
            RequestQuerystring.Add("timestamp", "1459779785");
        };

        Because of = () =>
        {
            IsValid = ShopifyAuthorizationService.IsAuthenticRequest(RequestQuerystring, Utils.SecretKey);
        };

        It should_authenticate_a_request = () =>
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
