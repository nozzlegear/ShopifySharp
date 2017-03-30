using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(AuthorizationService))]
    class When_validating_shop_url
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            FirstUrlIsValid = AuthorizationService.IsValidMyShopifyUrl(FirstUrl).Await().AsTask.Result;
            SecondUrlIsValid = AuthorizationService.IsValidMyShopifyUrl(SecondUrl).Await().AsTask.Result;
        };

        It should_validate_shop_url = () =>
        {
            FirstUrlIsValid.ShouldBeTrue();
            SecondUrlIsValid.ShouldBeFalse();
        };

        Cleanup after = () =>
        {

        };

        static string FirstUrl = Utils.MyShopifyUrl;

        static string SecondUrl = "https://google.com";

        static bool FirstUrlIsValid = false;

        static bool SecondUrlIsValid = false;
    }
}
