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
        const string graphql =
            """"
            """
            The information about the price that's charged to a shop every plan period.
            The concrete type can be `AppRecurringPricing` for recurring billing or `AppUsagePricing` for usage-based billing.
            """
            union AppPricingDetails = AppRecurringPricing | AppUsagePricing
            
            """
            The pricing information about a subscription app.
            The object contains an interval (the frequency at which the shop is billed for an app subscription) and
            a price (the amount to be charged to the subscribing shop at each interval).
            """
            type AppRecurringPricing {
              """
              The discount applied to the subscription for a given number of billing intervals.
              """
              discount: AppSubscriptionDiscount
            
              """
              The frequency at which the subscribing shop is billed for an app subscription.
              """
              interval: AppPricingInterval!
            
              """
              The amount and currency to be charged to the subscribing shop every billing interval.
              """
              price: MoneyV2!
            }
            
            """
             Defines a usage pricing model for the app subscription.
             These charges are variable based on how much the merchant uses the app.
             """
             type AppUsagePricing {
               """The total usage records for interval."""
               balanceUsed: MoneyV2!
             
               """
               The capped amount prevents the merchant from being charged for any usage over that amount during a billing period.
               This prevents billing from exceeding a maximum threshold over the duration of the billing period.
               For the merchant to continue using the app after exceeding a capped amount,
               they would need to agree to a new usage charge.
               """
               cappedAmount: MoneyV2!
             
               """The frequency with which the app usage records are billed."""
               interval: AppPricingInterval!
             
               """
               The terms and conditions for app usage pricing.
               Must be present in order to create usage charges.
               The terms are presented to the merchant when they approve an app's usage charges.
               """
               terms: String!
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
        const string graphql =
            //lang=graphql
            """"
            interface Foo {
              """The total number of orders placed for the location."""
              orderCount: Int! @deprecated(reason: "Use `ordersCount` instead.")
            }
            
            type Bar implements Foo {
              """The total number of orders placed for the location."""
              orderCount: Int! @deprecated(reason: "Use `ordersCount` instead.")
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
}
