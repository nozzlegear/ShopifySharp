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
    class When_deleting_a_webhook
    {
        Establish context = () =>
        {
            Service = new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);
            Id = Service.CreateAsync(WebhookCreation.CreateValidWebhook()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            try
            {
                Service.DeleteAsync(Id.Value).Await();
            }
            catch (ShopifyException e)
            {
                Exception = e;
            }
        };

        It should_delete_a_webhook = () =>
        {
            Exception.ShouldBeNull();
        };

        Cleanup after = () =>
        {
        };

        static WebhookService Service;
        static ShopifyException Exception;
        static long? Id;
    }
}
