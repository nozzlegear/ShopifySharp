using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using ShopifySharp.Enums;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyWebhookService))]
    public class When_listing_webhooks_with_a_filter
    {
        Establish context = () =>
        {
            Service = new ShopifyWebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

            // Create 4 normal webhooks to retrieve
            for (int i = 0; i < 4; i++)
            {
                CreatedWebhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result);
            }

            // Create 4 distinct webhooks to retrieve
            for (int i = 0; i < 4; i++)
            {
                CreatedWebhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook(topic: FilterTopic)).Await().AsTask.Result);
            }

            Options = new ShopifyWebhookFilterOptions()
            {
                Topic = FilterTopic
            };
        };

        Because of = () =>
        {
            Result = Service.ListAsync(Options).Await().AsTask.Result;
        };

        It should_retrieve_a_list_of_filtered_webhooks = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().ShouldBeGreaterThanOrEqualTo(4);
            Result.Any(x => x.Topic != FilterTopic).ShouldBeFalse();
        };

        Cleanup after = () =>
        {
            foreach (ShopifyWebhook webhook in CreatedWebhooks)
            {
                Service.DeleteAsync(webhook.Id.Value).Await();
            }
        };

        static ShopifyWebhookService Service;
        static IEnumerable<ShopifyWebhook> Result;
        static ShopifyWebhookTopic FilterTopic = ShopifyWebhookTopic.ShopUpdated;
        static List<ShopifyWebhook> CreatedWebhooks = new List<ShopifyWebhook>();
        static ShopifyWebhookFilterOptions Options;
    }
}
