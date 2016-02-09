using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp.Enums;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyAuthorizationService))]
    public class When_building_an_authorization_url
    {
        Establish context = () =>
        {
            _Scopes = new List<ShopifyAuthorizationScope>()
            {
                ShopifyAuthorizationScope.ReadCustomers,
                ShopifyAuthorizationScope.WriteCustomers
            };
        };

        Because of = () =>
        {
            _Result = ShopifyAuthorizationService.BuildAuthorizationUrl(_Scopes, Utils.MyShopifyUrl, Utils.ApiKey);
        };

        It should_build_an_authorization_url = () =>
        {
            _Result.ToString().ShouldContain($"/admin/oauth/authorize?client_id={Utils.ApiKey}&scope=read_customers,write_customers");
        };

        Cleanup after = () =>
        {

        };

        static List<ShopifyAuthorizationScope> _Scopes;
        static Uri _Result;
    }
}
