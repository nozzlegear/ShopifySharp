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

        Because of = async () =>
        {
            _Shop = await _Service.GetShopInformationAsync();
        };

        It should_retrieve_a_shop = () =>
        {
            Utils.MyShopifyUrl.ShouldNotBeEmpty();
            Utils.MyShopifyUrl.ShouldNotBeNull();
            _Shop.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyShopService _Service;
        static ShopifyShop _Shop;
    }
}
