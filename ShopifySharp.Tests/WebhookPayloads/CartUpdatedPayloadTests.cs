using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using ShopifySharp.WebhookPayloads.CartUpdated;
using Xunit;

namespace ShopifySharp.Tests.WebhookPayloads
{
    [Trait("Category", "CartUpdatedPayload")]
    public class CartUpdatedPayloadTests
    {
        private const string JsonFilePath = "./WebhookPayloads/cart_updated_payload.json";
        private const string JsonWithPropertiesFilePath = "./WebhookPayloads/cart_updated_payload_with_properties.json";

        [Fact]
        public async Task ShouldDeserializeACartWebhookUpdatedRequest()
        {
            // Setup
            var json = await ReadJsonFile();

            // Act
            var act = () => Infrastructure.Serializer.Deserialize<CartUpdatedPayload>(json);

            // Test
            act.Should().NotThrow();

            var subject = act.Should().NotThrow().Subject;

            subject.Should().NotBeNull();
            subject.Id.Should().NotBeNullOrWhiteSpace();
            subject.Token.Should().NotBeNullOrWhiteSpace();
            subject.Note.Should().Be("");
            subject.CreatedAt.Should().Be(new DateTimeOffset(2023, 12, 11, 04, 40, 09, 792, TimeSpan.FromHours(0)));
            subject.UpdatedAt.Should().Be(new DateTimeOffset(2023, 12, 11, 04, 44, 14, 751, TimeSpan.FromHours(0)));
            subject.LineItems.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public async Task ShouldDeserializeACartWebhookPayload_WithLineItems()
        {
            // Setup
            var json = await ReadJsonFile();

            // Act
            var lineItems = Infrastructure.Serializer.Deserialize<CartUpdatedPayload>(json).LineItems;
            var lineItem = lineItems.Single();

            // Test
            lineItem.Should().NotBeNull();
            lineItem.Id.Should().HaveValue();
            lineItem.Properties.Should().BeNull();
            lineItem.Quantity.Should().BeGreaterThan(0);
            lineItem.VariantId.Should().BeGreaterThan(0);
            lineItem.Key.Should().NotBeNullOrWhiteSpace();
            lineItem.Grams.Should().HaveValue();
            lineItem.ProductId.Should().BeGreaterThan(0);
            lineItem.Sku.Should().Be("test-sku");
            lineItem.Title.Should().Be("The Collection Snowboard: Liquid");

            // Check exact values for prices, because they're strings in the json and converted to decimals in the object for convenience
            lineItem.DiscountedPrice.Should().Be(749.95M);
            lineItem.LinePrice.Should().Be(2249.85M);
            lineItem.OriginalLinePrice.Should().Be(2249.85M);
            lineItem.OriginalPrice.Should().Be(749.95M);
            lineItem.Price.Should().Be(749.95M);
            lineItem.TotalDiscount.Should().Be(0.00M);
        }

        [Fact]
        public async Task ShouldDeserializeACartWebhookPayload_WithShopMoneyAndPresentmentMoneyObjects()
        {
            // Setup
            var json = await ReadJsonFile();

            // Act
            var lineItems = Infrastructure.Serializer.Deserialize<CartUpdatedPayload>(json).LineItems;
            var lineItem = lineItems.Single();

            // Test
            lineItem.Should().NotBeNull();
            // Check exact values for prices, because they're strings in the json and converted to decimals in the object for convenience
            TestShopMoneyObject(lineItem.DiscountedPriceSet.ShopMoney, 749.95M);
            TestShopMoneyObject(lineItem.LinePriceSet.ShopMoney, 2249.85M);
            TestShopMoneyObject(lineItem.OriginalLinePriceSet.ShopMoney, 2249.85M);
            TestShopMoneyObject(lineItem.PriceSet.ShopMoney, 749.95M);
            TestShopMoneyObject(lineItem.TotalDiscountSet.ShopMoney, 0.00M);

            TestPresentmentMoneyObject(lineItem.DiscountedPriceSet.PresentmentMoney, 749.95M);
            TestPresentmentMoneyObject(lineItem.LinePriceSet.PresentmentMoney, 2249.85M);
            TestPresentmentMoneyObject(lineItem.OriginalLinePriceSet.PresentmentMoney, 2249.85M);
            TestPresentmentMoneyObject(lineItem.PriceSet.PresentmentMoney, 749.95M);
            TestPresentmentMoneyObject(lineItem.TotalDiscountSet.PresentmentMoney, 0.00M);
        }

        [Fact]
        public async Task ShouldDeserializeACartWebhookPayload_WithProperties()
        {
            // Setup
            var json = await ReadJsonFile(JsonWithPropertiesFilePath);

            // Act
            var lineItems = Infrastructure.Serializer.Deserialize<CartUpdatedPayload>(json).LineItems;
            var properties = lineItems.Single().Properties;

            // Test
            properties.Should().NotBeNullOrEmpty();
            properties.Should().ContainKey("customization_name").WhoseValue.Should().Be("John Doe");
            properties.Should().ContainKey("__hidden_prop").WhoseValue.Should().Be("Foo");
            properties.Should().ContainKey("bool_prop").WhoseValue.Should().Be(true);
            properties.Should().ContainKey("int_prop").WhoseValue.Should().Be(2);
            properties.Should()
                .ContainKey("obj_prop")
                .WhoseValue.Should()
                .BeOfType<JObject>();
            properties.Should()
                .ContainKey("array_prop")
                .WhoseValue.Should()
                .BeOfType<JArray>();
        }

        private static void TestShopMoneyObject(CartUpdatedShopMoney shopMoney, decimal expectedAmount)
        {
            shopMoney.Should().NotBeNull();
            shopMoney.Amount.Should().Be(expectedAmount);
            shopMoney.CurrencyCode.Should().NotBeNullOrWhiteSpace();
        }

        private static void TestPresentmentMoneyObject(CartUpdatedPresentmentMoney presentmentMoney, decimal expectedAmount)
        {
            presentmentMoney.Should().NotBeNull();
            presentmentMoney.Amount.Should().Be(expectedAmount);
            presentmentMoney.CurrencyCode.Should().NotBeNullOrWhiteSpace();
        }

        private static async Task<string> ReadJsonFile(string filename = null)
        {
            filename = filename ?? JsonFilePath;

            #if NET472
            var jsonLines = File.ReadAllLines(filename);
            var json = String.Join("", jsonLines);
            #else
            var json = await File.ReadAllTextAsync(filename);
            #endif
            return json;
        }
    }
}
