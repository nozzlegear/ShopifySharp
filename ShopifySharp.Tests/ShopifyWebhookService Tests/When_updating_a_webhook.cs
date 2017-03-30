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
    class When_updating_a_webhook
    {
        Establish context = () =>
        {
            Service = new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);
            Webhook = Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result;

            //Preserve the original webhook address
            OriginalAddress = Webhook.Address;

            //Add more fields to the webhook
            List<string> fields = Webhook.Fields.ToList();
            List<string> metaFields = Webhook.MetafieldNamespaces.ToList();

            fields.Add(NewField);
            metaFields.Add(NewMetaField);

            //Modify the webhook to update
            Webhook.Address += NewPath;
            Webhook.Fields = fields;
            Webhook.MetafieldNamespaces = metaFields;
        };

        Because of = () =>
        {
            Webhook = Service.UpdateAsync(Webhook).Await().AsTask.Result;
        };

        It should_update_a_webhook = () =>
        {
            Webhook.ShouldNotBeNull();
            Webhook.Fields.ShouldContain(NewField);
            Webhook.MetafieldNamespaces.ShouldContain(NewMetaField);
            Webhook.Address.ShouldEqual(OriginalAddress + NewPath);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Webhook.Id.Value).Await();
        };

        static WebhookService Service;
        static Webhook Webhook;
        static string OriginalAddress;
        static string NewPath = "/updated-address";
        static string NewMetaField = "UpdatedMetaField";
        static string NewField = "UpdatedField";
    }
}
