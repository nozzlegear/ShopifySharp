using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyApplicationCreditService_Tests
{
    [Subject(typeof(ShopifyApplicationCreditService))]
    class When_listing_application_credits
    {
        Establish context = () =>
        {
            
        };

        Because of = () =>
        {
            Credits = AppCreditUtils.Service.ListAsync().Await().AsTask.Result;
        };
        
        It should_list_application_credits = () =>
        {
            Credits.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };
        
        static IEnumerable<ShopifyApplicationCredit> Credits;
    }
}
