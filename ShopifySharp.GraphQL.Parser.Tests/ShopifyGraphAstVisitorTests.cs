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
    public async Task ShouldParseSchemaDefinitions()
    {
        // Setup
        //lang=gql
        var graphql =
            """"
            schema {
              query: QueryRoot
              mutation: Mutation
            }

            """Marks an element of a GraphQL schema as having restricted access."""
            directive @accessRestricted(
              """Explains the reason around this restriction"""
              reason: String = null
            ) on FIELD_DEFINITION | OBJECT

            """
            Requires that exactly one field must be supplied and that field must not be `null`.
            """
            directive @oneOf on INPUT_OBJECT

            """Exposes a URL that specifies the behavior of this scalar."""
            directive @specifiedBy(
              """The URL that specifies the behavior of this scalar."""
              url: String!
            ) on SCALAR
            """";

        // Act
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        text.Should().Be(
            """
            would write comments 0
            would write description [none]
            would write directives 0
            root operation: QueryRoot
            root operation: Mutation
            directive desc: Marks an element of a GraphQL schema as having restricted access.
            directive name: accessRestricted
            argument name: reason
            argument desc: Explains the reason around this restriction
            argument default value: NullValue
            argument is child definition: True
            directive desc: Requires that exactly one field must be supplied and that field must not be `null`.
            directive name: oneOf
            directive desc: Exposes a URL that specifies the behavior of this scalar.
            directive name: specifiedBy
            argument name: url
            argument desc: The URL that specifies the behavior of this scalar.
            argument default value: 
            argument is child definition: True
            
            """
        );
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
}
