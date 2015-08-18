using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyWebhookService))]
    public class When_listing_webhooks
    {
        Establish context = () =>
        {
            Service = new ShopifyWebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

            // Create 4 webhooks to retrieve
            for(int i = 0; i < 4; i++)
            {
                CreatedWebhooks.Add(Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            Result = Service.ListAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_list_of_webhooks = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().ShouldBeGreaterThanOrEqualTo(CreatedWebhooks.Count);
        };

        Cleanup after = () =>
        {
            foreach(ShopifyWebhook webhook in CreatedWebhooks)
            {
                Service.DeleteAsync(webhook.Id.Value).Await();
            }
        };

        static List<ShopifyWebhook> CreatedWebhooks = new List<ShopifyWebhook>();
        static ShopifyWebhookService Service;
        static IEnumerable<ShopifyWebhook> Result;
    }
}
