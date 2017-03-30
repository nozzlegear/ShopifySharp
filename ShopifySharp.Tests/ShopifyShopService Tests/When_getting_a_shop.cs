using Machine.Specifications;
using System;
using Machine.Specifications.Sdk;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopService), "Shop"), Tags("Shop")]
    public class When_getting_a_shop
    {
        Establish context = () =>
        {
            _Service = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            //MSpec test suite does not support async/await
            _Shop = _Service.GetAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_shop = () =>
        {
            _Shop.ShouldNotBeNull();
            _Shop.ForceSSL.HasValue.ShouldBeTrue();
            string.IsNullOrEmpty(_Shop.PlanDisplayName).ShouldBeFalse();
        };

        Cleanup after = () =>
        {

        };

        static ShopService _Service;
        static Shop _Shop;
    }
}
