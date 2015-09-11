using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class WebhookCreation
    {
        public static ShopifyWebhook CreateValidWebhook(string path = null, ShopifyWebhookTopic topic = ShopifyWebhookTopic.OrderCreated)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = Guid.NewGuid().ToString();
            }

            return new ShopifyWebhook()
            {
                Address = "https://requestb.in/" + path,
                CreatedAt = DateTime.Now,
                Fields = new List<string>() { "field1", "field2" },
                Format = "json",
                MetafieldNamespaces = new List<string>() { "metafield1", "metafield2" },
                Topic = topic,
            };
        }
    }
}
