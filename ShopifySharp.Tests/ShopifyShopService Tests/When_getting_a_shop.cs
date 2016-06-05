using Machine.Specifications;
using System;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyShopService))]
    public class When_getting_a_shop
    {
        Establish context = () =>
        {
            _Service = new ShopifyShopService(Utils.MyShopifyUrl, Utils.AccessToken);
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
        };

        Cleanup after = () =>
        {

        };

        static ShopifyShopService _Service;
        static ShopifyShop _Shop;
    }
}
