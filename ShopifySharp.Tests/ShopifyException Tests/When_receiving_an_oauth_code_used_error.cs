using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyException_Tests
{
    [Subject(typeof(ShopifyException))]
    class When_receiving_an_oauth_code_used_error
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Ex = Catch.Exception(() => Service.ThrowOAuthCodeUsedException());
        };

        It should_parse_an_oauth_code_used_error = () =>
        {
            Ex.ShouldBeOfExactType<ShopifyException>();

            var e = (ShopifyException)Ex;

            e.Message.ShouldContain("authorization code was not found or was already used");
            e.JsonError.ShouldNotBeNull();
            e.Errors.Count.ShouldEqual(1);
            e.Errors.First().Key.ShouldEqual("invalid_request");
            e.Errors.First().Value.Count().ShouldEqual(1);
        };

        Cleanup after = () =>
        {

        };

        static ShopifyExceptionService Service = new ShopifyExceptionService(Utils.MyShopifyUrl, Utils.AccessToken);

        static Exception Ex;
    }
}
