using Machine.Specifications;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyLocationService_Tests
{
    [Subject(typeof(LocationService))]
    public class When_getting_a_location
    {
        Establish context = () =>
        {
            Service = new LocationService(Utils.MyShopifyUrl, Utils.AccessToken);

            var list = Service.ListAsync().Await().AsTask.Result;

            // Not all shops have a location
            if (list.Count() > 0)
            {
                Id = list.FirstOrDefault().Id;
            }
        };

        Because of = () =>
        {
            // Not all shops have a location
            if (Id.HasValue)
            {
                Result = Service.GetAsync(Id.Value).Await().AsTask.Result;
            }
        };

        It should_get_a_location = () =>
        {
            // Not all shops have a location
            if (Result != null)
            {
                Result.Address1.ShouldNotBeNull();
                Result.Id.HasValue.ShouldBeTrue();
                Result.City.ShouldNotBeNull();
                Result.Province.ShouldNotBeNull();
                Result.Zip.ShouldNotBeNull();
                Result.Country.ShouldNotBeNull();
            }
        };

        Cleanup after = () =>
        {

        };

        static LocationService Service;

        static Location Result;

        static long? Id;
    }
}
