using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.Parser.Tests;

[TestSubject(typeof(Parser))]
public class GraphClassSerializerTests(VerifyFixture verifyFixture) : IClassFixture<VerifyFixture>
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
        var result = sut.ParseAsync(graphql.AsMemory()).ToBlockingEnumerable();

        // Assert
        await Verify(result, verifyFixture.Settings);
    }
}
