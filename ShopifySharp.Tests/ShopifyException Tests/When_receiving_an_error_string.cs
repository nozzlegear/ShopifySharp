using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyException_Tests
{
    [Subject(typeof(ShopifyException))]
    class When_receiving_an_error_string
    {
        Establish context = () =>
        {
            service = new ShopifyExceptionService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            ex = Catch.Exception(() => service.ThrowStringException().Await());
        };

        It should_parse_a_single_error = () =>
        {
            ex.ShouldBeOfExactType<ShopifyException>();

            var e = (ShopifyException)ex;
            
            e.JsonError.ShouldNotBeNull();

            e.Errors.Count.ShouldEqual(1);
            e.Errors.First().Key.ShouldEqual("Error");
            e.Errors.First().Value.Count().ShouldEqual(1);
        };

        Cleanup after = () =>
        {

        };

        static ShopifyExceptionService service;

        static Exception ex;
    }
}
