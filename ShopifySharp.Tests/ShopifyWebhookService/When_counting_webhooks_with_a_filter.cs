using Machine.Specifications;
using ShopifySharp.Enums;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyWebhookService))]
    public class When_counting_webhooks_with_a_filter
    {
        Establish context = () =>
        {
            Service = new ShopifyWebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create one webhook with the original address
            Webhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result);

            //Create 5 other webhooks with a different topic
            for(int i  = 0; i < 5; i++)
            {
                //Webhooks need a unique address
                Webhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook("counting-with-filter-" + i, FilterTopic)).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            AllCount = Service.CountAsync().Await().AsTask.Result;
            FilteredCount = Service.CountAsync(topic: FilterTopic).Await().AsTask.Result;
        };

        It should_count_webhooks_with_a_filter = () =>
        {
            AllCount.ShouldNotBeNull();
            FilteredCount.ShouldNotBeNull();
            AllCount.ShouldNotEqual(FilteredCount);
            FilteredCount.ShouldBeGreaterThanOrEqualTo(5);
        };

        Cleanup after = () =>
        {
            foreach(ShopifyWebhook hooks in Webhooks)
            {
                Service.DeleteAsync(hooks.Id.Value).Await();
            }
        };

        static ShopifyWebhookService Service;
        static int? AllCount;
        static int? FilteredCount;
        static ShopifyWebhookTopic FilterTopic = ShopifyWebhookTopic.ShopUpdated;
        static List<ShopifyWebhook> Webhooks = new List<ShopifyWebhook>();
    }
}
