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
    [Subject(typeof(WebhookService))]
    public class When_counting_webhooks_with_a_filter
    {
        Establish context = () =>
        {
            Service = new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create one webhook with the original topic
            Webhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result);

            //Create 5 other webhooks with a different topic
            for(int i  = 0; i < 5; i++)
            {
                Webhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook(topic: FilterTopic)).Await().AsTask.Result);
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
            foreach(Webhook hooks in Webhooks)
            {
                Service.DeleteAsync(hooks.Id.Value).Await();
            }
        };

        static WebhookService Service;
        static int? AllCount;
        static int? FilteredCount;
        static string FilterTopic = "shop/update";
        static List<Webhook> Webhooks = new List<Webhook>();
    }
}
