using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyWebhookService))]
    public class When_counting_webhooks
    {
        Establish context = () =>
        {
            Service = new ShopifyWebhookService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Count = Service.CountAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_count_of_customers = () =>
        {
            Count.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyWebhookService Service;
        static int? Count;
    }
}
