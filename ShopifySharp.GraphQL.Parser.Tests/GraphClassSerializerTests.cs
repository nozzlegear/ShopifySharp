namespace ShopifySharp.GraphQL.Parser.Tests;

public class GraphClassSerializerTests
{
    private readonly Parser _sut = new();

    [Fact]
    public async Task ShouldParseInputDefinition()
    {
        // Setup
        const string graphql =
            """"
            """
            The input fields to specify the value discounted every billing interval.
            """
            input AppSubscriptionDiscountValueInput {
              """The monetary value of a discount."""
              amount: Decimal
            
              """The percentage value of a discount."""
              percentage: Float
            }
            """";

        // Act
        var result = await _sut.ParseAsync(graphql.AsMemory());

        // Assert
        result.Should().Be(
            """
            public record AppSubscriptionDiscountValueInput
            {
                /// <summary>
                /// The monetary value of a discount.
                /// </summary>
                [System.Text.Json.JsonProperty("amount")]
                public decimal Amount { get; set; }

                /// <summary>
                /// The percentage value of a discount.
                /// </summary>
                [System.Text.Json.JsonProperty("percentage")]
                public decimal Percentage { get; set; }
            }
            """
        );
    }
}
