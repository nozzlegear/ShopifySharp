using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyCustomerService))]
    public class When_counting_customers
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            //MSpec test suite does not support async/await
            _Count = _Service.CountAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_count = () =>
        {
            _Count.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyCustomerService _Service;
        static int? _Count;
    }
}
