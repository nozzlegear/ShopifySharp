using Machine.Specifications;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyLocationService_Tests
{
    [Subject(typeof(ShopifyLocationService))]
    public class When_listing_locations
    {
        Establish context = () =>
        {
            Service = new ShopifyLocationService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Result = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_locations = () =>
        {
            Result.ShouldNotBeNull();

            var first = Result.FirstOrDefault();

            if (first != null)
            {
                first.Address1.ShouldNotBeNull();
                first.Id.HasValue.ShouldBeTrue();
                first.City.ShouldNotBeNull();
                first.Province.ShouldNotBeNull();
                first.Zip.ShouldNotBeNull();
                first.Country.ShouldNotBeNull();
            }
        };

        Cleanup after = () =>
        {

        };

        static ShopifyLocationService Service;

        static IEnumerable<Location> Result;
    }
}
