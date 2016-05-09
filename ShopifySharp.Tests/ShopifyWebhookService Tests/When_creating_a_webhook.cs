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
    class When_creating_a_webhook
    {
        Establish context = () =>
        {
            Service = new ShopifyWebhookService(Utils.MyShopifyUrl, Utils.AccessToken);
            ExampleWebhook = WebhookCreation.CreateValidWebhook(topic: ShopifyWebhookTopic.ThemePublished);
        };

        Because of = () =>
        {
            Webhook = Service.CreateAsync(ExampleWebhook).Await().AsTask.Result;
        };

        It should_create_a_webhook = () =>
        {
            Webhook.ShouldNotBeNull();
            Webhook.Id.HasValue.ShouldBeTrue();
            Webhook.Fields.ShouldContain(ExampleWebhook.Fields);
            Webhook.MetafieldNamespaces.ShouldContain(ExampleWebhook.MetafieldNamespaces);
            Webhook.Topic.Equals(ExampleWebhook.Topic).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Webhook.Id.Value).Await();
        };

        static ShopifyWebhookService Service;
        static ShopifyWebhook ExampleWebhook;
        static ShopifyWebhook Webhook;
    }
}
