using System;
using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using ShopifySharp.Entities.CartUpdatedWebhook;
using Xunit;

namespace ShopifySharp.Tests.Entities
{
    [Trait("Category", "CartUpdatedWebhookRequest")]
    public class CartUpdatedWebhookTests
    {
        private const string JsonFilePath = $"./Entities/cart_updated_webhook.json";

        [Fact]
        public async Task ShouldDeserializeACartWebhookUpdatedRequest()
        {
            #if NET6_0_OR_GREATER
            var json = await File.ReadAllTextAsync(JsonFilePath);
            #else
            var jsonLines = File.ReadAllLines(JsonFilePath);
            var json = String.Join("", jsonLines);
            #endif

            Func<CartUpdatedWebhookRequest> act = () => Infrastructure.Serializer.Deserialize<CartUpdatedWebhookRequest>(json);

            act.Should().NotThrow();

            var subject = act.Should().NotThrow().Subject;

            subject.Should().NotBeNull();
            subject.Id.Should().NotBeNullOrWhiteSpace();
            subject.Token.Should().NotBeNullOrWhiteSpace();
            subject.Note.Should().Be("");
            subject.CreatedAt.Should().NotBeNull();
            subject.UpdatedAt.Should().NotBeNull();
            subject.LineItems.Should().NotBeNullOrEmpty();
        }
    }
}
