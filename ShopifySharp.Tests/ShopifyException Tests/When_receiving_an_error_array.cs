using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyException_Tests
{
    [Subject(typeof(ShopifyException)), Tags("ShopifyException")]
    class When_receiving_an_error_array
    {
        Establish context = () =>
        {
            service = new ShopifyExceptionService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            ex = Catch.Exception(() => service.ThrowArrayException().Await());
        };

        It should_parse_an_array_error = () =>
        {
            ex.ShouldBeOfExactType<ShopifyException>();

            var e = (ShopifyException)ex;

            e.JsonError.ShouldNotBeNull();

            e.Errors.Count.ShouldBeGreaterThanOrEqualTo(1);
            e.Errors.Any(error => error.Key.Equals("order")).ShouldBeTrue();
            e.Errors.First(err => err.Key.Equals("order")).Value.First().ShouldNotBeNull();
            e.Errors.First(err => err.Key.Equals("order")).Value.Count().ShouldBeGreaterThanOrEqualTo(1);
            e.Errors.All(err => err.Value.Count() > 1);
        };

        Cleanup after = () =>
        {

        };

        static ShopifyExceptionService service;

        static Exception ex;
    }
}
