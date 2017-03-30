using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp.Enums;

namespace ShopifySharp.Tests
{
    [Subject(typeof(AuthorizationService))]
    public class When_building_an_authorization_url_with_grants
    {
        Establish context = () =>
        {
            RandomState = Guid.NewGuid().ToString();

            _Scopes = new List<ShopifyAuthorizationScope>()
            {
                ShopifyAuthorizationScope.ReadCustomers,
                ShopifyAuthorizationScope.WriteCustomers
            };
        };

        Because of = () =>
        {
            _Result = AuthorizationService.BuildAuthorizationUrl(_Scopes, Utils.MyShopifyUrl, Utils.ApiKey, state: RandomState, grants: new List<string>() { "per-user" });
        };

        It should_build_an_authorization_url_with_grants = () =>
        {
            _Result.ToString().ShouldContain($"/admin/oauth/authorize?client_id={Utils.ApiKey}&scope=read_customers,write_customers&state={RandomState}&grant_options[]=per-user");
        };

        Cleanup after = () =>
        {

        };

        static List<ShopifyAuthorizationScope> _Scopes;

        static string RandomState;

        static Uri _Result;
    }
}
