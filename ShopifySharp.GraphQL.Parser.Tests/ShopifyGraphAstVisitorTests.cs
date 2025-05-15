using System.IO.Pipelines;
using System.Text;

namespace ShopifySharp.GraphQL.Parser.Tests;

public class ShopifyGraphAstVisitorTests
{
    private readonly Pipe _pipe = new Pipe();
    private readonly WriterContext _writerContext;
    private readonly CancellationToken _cancellationToken = CancellationToken.None;

    private readonly ShopifyGraphAstVisitor _sut;

    public ShopifyGraphAstVisitorTests()
    {
        _writerContext = new WriterContext(_pipe.Writer, _cancellationToken);

        _sut = new ShopifyGraphAstVisitor();
    }

    private async Task<string> GetTextWrittenToPipeAsync()
    {
        var text = "";

        while (true)
        {
            var readResult = await _pipe.Reader.ReadAsync(_cancellationToken);
            if (readResult.IsCanceled)
                break;

            var buffer = readResult.Buffer;
            foreach (var segment in buffer)
            {
                text += Encoding.UTF8.GetString(segment.Span);
            }

            _pipe.Reader.AdvanceTo(buffer.End);

            if (readResult.IsCompleted)
                break;
        }

        return text;
    }

    [Fact]
    public async Task ShouldParseInputDefinition()
    {
        // Setup
        var graphql =
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
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        text.Should().Be(
            //lang=cs
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

    [Fact]
    public async Task ShouldParseEnumDefinition()
    {
        // Setup
        const string graphql =
            //lang=graphql
            """"
            """Specifies the abandonment type."""
            enum AbandonmentAbandonmentType {
              """The abandonment event is an abandoned browse."""
              BROWSE
            
              """The abandonment event is an abandoned cart."""
              CART
            
              """The abandonment event is an abandoned checkout."""
              CHECKOUT
            }
            """";

        // Act
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        text.Should().Be(
            //lang=cs
            """
            /// <summary>
            /// Specifies the abandonment type.
            /// </summary>
            public enum AbandonmentAbandonmentType
            {
                /// <summary>
                /// The abandonment event is an abandoned browse.
                /// </summary>
                [System.Text.Json.JsonProperty("BROWSE")]
                BROWSE,

                /// <summary>
                /// The abandonment event is an abandoned cart.
                /// </summary>
                [System.Text.Json.JsonProperty("CART")]
                CART,

                /// <summary>
                /// The abandonment event is an abandoned checkout.
                /// </summary>
                [System.Text.Json.JsonProperty("CHECKOUT")]
                CHECKOUT
            }

            """
        );
    }

    [Fact]
    public async Task ShouldParseTypeDefinition()
    {
        const string graphql =
            //lang=graphql
            """"
            """
            The permission required to access a Shopify Admin API or Storefront API resource
            for a shop. Merchants grant access scopes that are requested by applications.
            """
            type AccessScope {
              """
              A description of the actions that the access scope allows an app to perform.
              """
              description: String!
              """
              A readable string that represents the access scope. The string usually follows
              the format `{action}_{resource}`. `{action}` is `read` or `write`, and
              `{resource}` is the resource that the action can be performed on. `{action}`
              and `{resource}` are separated by an underscore. For example, `read_orders` or
              `write_products`.
              """
              handle: String!
            }
            """";

        // Act
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        text.Should().Be(
            //lang=cs
            """
            /// <summary>
            /// The permission required to access a Shopify Admin API or Storefront API resource
            /// for a shop. Merchants grant access scopes that are requested by applications.
            /// </summary>
            public record AccessScope
            {
                /// <summary>
                /// A description of the actions that the access scope allows an app to perform.
                /// </summary>
                [System.Text.Json.JsonProperty("description")]
                public string Description { get; set; }

                /// <summary>
                /// A readable string that represents the access scope. The string usually follows
                /// the format `{action}_{resource}`. `{action}` is `read` or `write`, and
                /// `{resource}` is the resource that the action can be performed on. `{action}`
                /// and `{resource}` are separated by an underscore. For example, `read_orders` or
                /// `write_products`.
                /// </summary>
                [System.Text.Json.JsonProperty("handle")]
                public string Handle { get; set; }
            }

            """
        );
    }

    [Fact]
    public async Task ShouldParseInterfaces()
    {
        // Setup
        const string graphql =
            //lang=graphql
            """"
            """The subject line of a comment event."""
            interface CommentEventSubject {
              """
              Whether the timeline subject has a timeline comment. If true, then a timeline comment exists.
              """
              hasTimelineComment: Boolean!

              """A globally-unique ID."""
              id: ID!
            }
            """";
        
        // Act
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        text.Should().Be(
            //lang=cs
            """
            /// <summary>
            /// The subject line of a comment event.
            /// </summary>
            public interface ICommentEventSubject
            {
                /// <summary>
                /// Whether the timeline subject has a timeline comment. If true, then a timeline comment exists.
                /// </summary>
                [System.Text.Json.JsonProperty("hasTimelineComment")]
                public bool HasTimelineComment { get; set; }

                /// <summary>
                /// A globally-unique ID.
                /// </summary>
                [System.Text.Json.JsonProperty("id")]
                public string Id { get; set; }
            }

            """
        );
    }

    [Fact]
    public async Task ShouldParseTypesThatHaveInterfaces()
    {
        Assert.Fail("test not implemented");
    }

    [Fact]
    public async Task ShouldParseUnionTypeDefinition()
    {
        Assert.Fail("test not implemented");
    }

    [Fact]
    public async Task ShouldParseTypeDefinitionsThatReferenceOtherTypes()
    {
        Assert.Fail("test not implemented");
    }

    [Fact]
    public async Task ShouldParseDefinitionsThatHavePropertiesWithParameters()
    {
        Assert.Fail("test not implemented");
    }
}
