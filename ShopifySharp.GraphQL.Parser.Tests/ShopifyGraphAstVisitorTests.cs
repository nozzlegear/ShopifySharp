using System.IO.Pipelines;
using System.Text;

namespace ShopifySharp.GraphQL.Parser.Tests;

public class ShopifyGraphAstVisitorTests: IClassFixture<VerifyFixture>
{
    private readonly VerifySettings _verifySettings;

    private readonly Pipe _pipe = new();
    private readonly WriterContext _writerContext;
    private readonly CancellationToken _cancellationToken = CancellationToken.None;

    private readonly ShopifyGraphAstVisitor _sut;

    public ShopifyGraphAstVisitorTests(VerifyFixture verifyFixture)
    {
        _verifySettings = verifyFixture.Settings;
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
        await Verify(text, _verifySettings);
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
        await Verify(text, _verifySettings);
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
        await Verify(text, _verifySettings);
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
        await Verify(text, _verifySettings);
    }

    [Fact]
    public async Task ShouldParseTypesThatHaveInterfaces()
    {
        // Setup
        const string graphql =
            //lang=graphql
            """"
            interface Node {
              """A globally-unique ID."""
              id: ID!
            }
          
            """A Shopify application."""
            type App implements Node {
              """A unique application API identifier."""
              apiKey: String!
              
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
        await Verify(text, _verifySettings);
    }

    [Fact]
    public async Task ShouldParseUnionTypeDefinition()
    {
        Assert.Fail("test not implemented");
    }

    [Fact]
    public async Task ShouldParseTypeDefinitionsThatReferenceOtherTypes()
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
            
            """
            A Shopify application.
            """
            type AppInstallation {
              """A unique application API identifier."""
              apiKey: String!
              """
              The optional scopes requested by the app. Lists the optional access scopes the
              app has declared in its configuration. These scopes are optionally requested
              by the app after installation.
              """
              optionalAccessScopes: [AccessScope!]!
              """
              The access scopes requested by the app. Lists the access scopes the app has
              declared in its configuration. Merchant must grant approval to these scopes
              for the app to be installed.
              """
              requestedAccessScopes: [AccessScope!]!
            }
            """";

        // Act
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        await Verify(text, _verifySettings);
    }

    [Fact]
    public async Task ShouldParseDefinitionsThatHavePropertiesWithParameters()
    {
        // Setup
        const string graphql =
            """"
            """
            Represents information about the metafields associated to the specified resource.
            """
            interface HasMetafields {
              """
              A [custom field](https://shopify.dev/docs/apps/build/custom-data),
              including its `namespace` and `key`, that's associated with a Shopify resource
              for the purposes of adding and storing additional information.
              """
              metafield(
                """The key for the metafield."""
                key: String!
            
                """
                The container the metafield belongs to. If omitted, the app-reserved namespace will be used.
                """
                namespace: String
              ): Metafield
            }
            
            """
            An example type that has metafields.
            """
            type ExampleTypeWithMetafields implements HasMetafields {
                
                """
                A [custom field](https://shopify.dev/docs/apps/build/custom-data),
                including its `namespace` and `key`, that's associated with a Shopify resource
                for the purposes of adding and storing additional information.
                """
                metafield(
                  """The key for the metafield."""
                  key: String!
                
                  """
                  The container the metafield belongs to. If omitted, the app-reserved namespace will be used.
                  """
                  namespace: String
                ): Metafield
            }
            """";

        // Act
        var ast = GraphQLParser.Parser.Parse(graphql);
        await _sut.VisitAsync(ast, _writerContext);
        await _pipe.Writer.CompleteAsync();

        // Assert
        var text = await GetTextWrittenToPipeAsync();
        await Verify(text, _verifySettings);
    }

    [Fact]
    public async Task ShouldParseTheDeprecatedDirectiveAndTransformItIntoAnObsoleteAttribute()
    {
        Assert.Fail("test not implemented");
    }
}
