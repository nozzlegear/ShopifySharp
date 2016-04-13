using Machine.Specifications;
using System;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyShopService))]
    public class When_uninstalling_an_app
    {
        Establish context = () =>
        {
            _Service = new ShopifyShopService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            _Service.UninstallAppAsync().Await();
        };

        [Ignore("This test cannot be completed because private apps (the kind used to test this library) cannot be uninstalled.")]
        It should_uninstall_the_app = () =>
        {

        };

        Cleanup after = () =>
        {

        };

        static ShopifyShopService _Service;
    }
}
