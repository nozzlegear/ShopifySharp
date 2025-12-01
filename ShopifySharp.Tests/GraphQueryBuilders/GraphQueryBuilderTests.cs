using JetBrains.Annotations;
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
}
