using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ShopifySharp.Tests
{
    [Subject(typeof(WebhookService))]
    public class When_listing_webhooks
    {
        Establish context = () =>
        {
            Service = new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

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
            foreach(Webhook webhook in CreatedWebhooks)
            {
                Service.DeleteAsync(webhook.Id.Value).Await();
            }
        };

        static List<Webhook> CreatedWebhooks = new List<Webhook>();
        static WebhookService Service;
        static IEnumerable<Webhook> Result;
    }
}
