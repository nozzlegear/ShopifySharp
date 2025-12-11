using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Services.Generated;
using ShopifySharp.Tests.Fixtures;

namespace ShopifySharp.Tests.GraphQueryBuilders;

[Trait("Category", "GraphQueryBuilder")]
[TestSubject(typeof(GraphQueryBuilder<>))]
public class GraphQueryBuilderTests(VerifyFixture verifyFixture): IClassFixture<VerifyFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;

    [Fact]
    public async Task QueryBuilder_WhenAliasIsSet_ShouldBuildQueryWithAlias()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.Alias("someAlias");

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #region Fields

    [Fact]
    public async Task QueryBuilder_WhenFieldIsAdded_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenMultipleFieldsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddFieldName();
        sut.AddFieldUpdatedAt();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenCustomFieldsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddField("fooField");

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenComplexFieldsAreAdded_ShouldBuildQueryWithSubquery()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddFieldBillingAddress(x =>
        {
            x.AddFieldAddress1();
            x.AddFieldAddress2();
            x.AddFieldCity();
            x.AddFieldZip();
            x.AddFieldCompany();
            x.AddFieldProvince();
            x.AddFieldCountryCodeV2();
            return x;
        });

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    #region AddArgument

    [Fact]
    public async Task QueryBuilder_AddArgument_WhenPrimitiveArgumentsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddArgument("foo", "bar");
        sut.AddArgument("bat", "baz");

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddArgument_WhenPrimitiveArgumentsAreAddedOfAnyType_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddArgument("foo", 3);
        sut.AddArgument("bar", true);
        sut.AddArgument("baz", false);
        sut.AddArgument("bat", 6.7);

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    #region AddArguments

    [Fact]
    public async Task QueryBuilder_AddArguments_WhenPrimitiveArgumentsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddArguments(new Dictionary<string, object>
        {
            { "foo", "bar" },
            { "bat", "baz" },
        });

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddArguments_WhenPrimitiveArgumentsAreAddedOfAnyType_ShouldBuild()
    {
        // Setup
        var sut = new ShopQueryBuilder();
        sut.AddFieldCreatedAt();
        sut.AddArguments(new Dictionary<string, object>
        {
            { "foo", 3 },
            { "bar", true },
            { "baz", false },
            { "bat", 6.7 },
        });

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    #region Unions

    [Fact]
    public async Task QueryBuilder_AddUnionCase_ShouldBuild()
    {
        // Setup
        var sut = new CalculatedDiscountCodeApplicationQueryBuilder();
        sut.AddFieldCode();
        sut.AddUnionCaseValue((MoneyV2QueryBuilder x) => x.AddFieldAmount());

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingMoreThanOneUnion_ShouldBuild()
    {
        // Setup
        var sut = new CalculatedDiscountCodeApplicationQueryBuilder();
        sut.AddFieldCode();
        sut.AddUnionCaseValue((MoneyV2QueryBuilder x) => x.AddFieldAmount());

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingCustomUnionTypes_ShouldBuild()
    {
        // Setup
        var sut = new CalculatedDiscountCodeApplicationQueryBuilder();
        sut.AddFieldCode();
        sut.AddUnionCaseValue((MoneyV2QueryBuilder x) => x.AddFieldAmount());
        sut.AddUnionCase<CustomThing, CustomThingQueryBuilder>("myCustomThing", x => x.AddFoo());

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    public class CustomThingQueryBuilder() : GraphQueryBuilder<CustomThing>("customThing")
    {
        public CustomThingQueryBuilder AddFoo()
        {
            AddField("foo");
            return this;
        }
    }

    public class CustomThing : IGraphQLUnionCase, IGraphQLObject;
}
