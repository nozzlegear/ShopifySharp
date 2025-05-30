using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.Parser.Tests;

[TestSubject(typeof(Parser))]
public class GraphClassSerializerTests
{
    private static Parser MakeParser(CasingType casingType = CasingType.PascalCase) =>
        new(casingType);


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
        var sut = MakeParser();

        // Act
        var result = await sut.ParseAsync(graphql.AsMemory());

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
