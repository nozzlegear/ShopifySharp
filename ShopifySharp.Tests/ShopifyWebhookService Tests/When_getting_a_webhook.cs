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
    class When_getting_a_webhook
    {
        Establish context = () =>
        {
            Service = new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);
            Id = Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Webhook = Service.GetAsync(Id.Value).Await().AsTask.Result;
        };

        It should_get_a_webhook = () =>
        {
            Webhook.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Webhook.Id.Value).Await();
        };

        static WebhookService Service;
        static long? Id;
        static Webhook Webhook;
    }
}
