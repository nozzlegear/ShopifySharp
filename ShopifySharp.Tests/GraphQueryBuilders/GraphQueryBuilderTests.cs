using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.Tests.Fixtures;

namespace ShopifySharp.Tests.GraphQueryBuilders;

[Trait("Category", "QueryBuilder")]
[TestSubject(typeof(QueryBuilderBase<,>))]
public class GraphQueryBuilderTests(VerifyFixture verifyFixture): IClassFixture<VerifyFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;

    [Fact]
    public void QueryBuilder_WhenQueryIsEmpty_ShouldBuildWithTypeName()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();

        // Act
        var result = sut.Build();

        // Assert
        result.Should().Be("metafield", "an empty Query<T> should serialize to its .Name");
    }

    [Fact]
    public async Task QueryBuilder_WhenAliasIsSet_ShouldBuildQueryWithAlias()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        sut.CreatedAt();
        sut.SetAlias("someAlias");

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #region FieldBuilderBase

    [Fact(DisplayName = "FieldBuilderBase: Accessing the QueryName or AliasName fields should return the InnerQuery field values instead")]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public void FieldBuilderBase_WhenAccessing_QueryName_Or_AliasName_Fields_ShouldReturnInnerQueryFieldsInstead()
    {
        // Setup
        const string queryName = "some-query-name";
        const string aliasName = "some-alias-name";
        var query = A.Fake<IQuery<IHasMetafields>>(x => x.Strict());

        A.CallTo(() => query.QueryName).Returns(queryName);
        A.CallTo(() => query.AliasName).Returns(aliasName);

        var sut = new HasMetafieldsQueryBuilder(query);

        // Act
        var a = sut.AliasName;
        var b = sut.QueryName;

        // Assert
        sut.AliasName.Should().Be(aliasName);
        sut.QueryName.Should().Be(queryName);

        A.CallTo(() => query.QueryName).MustHaveHappenedTwiceExactly();
        A.CallTo(() => query.AliasName).MustHaveHappenedTwiceExactly();
    }

    #endregion

    #region Fields

    [Fact]
    public async Task QueryBuilder_WhenFieldIsAdded_ShouldBuild()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        sut = sut.CreatedAt();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_MultipleFieldCalls_ShouldChainTogetherFluently()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        sut.CreatedAt()
            .Id()
            .Key();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddingFields_ShouldBeMutable()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        // We expect each of these calls to mutate the query builder rather than return a new instance,
        // i.e. each call should add a new property to the query builder.
        sut.CreatedAt();
        sut.Id();
        sut.Key();

        // Act
        var result = sut.Build();

        // Assert
        result.Should().ContainAll("createdAt", "id", "key");
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenCustomFieldsAreAdded_ShouldBuild()
    {
        // Setup
        const string customFieldName1 = "some-custom-field-name-1";
        const string customFieldName2 = "some-custom-field-name-2";
        var query = new Query<CustomBat>(customFieldName1);

        var sut = new MetafieldQueryBuilder();
        sut.CreatedAt()
            .Id()
            .Key()
            .AddField(query)
            .AddField(customFieldName2);

        // Act
        var result = sut.Build();

        // Assert
        result.Should().ContainAll(
            customFieldName1,
            customFieldName2
        );
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenCustomFieldsUsingNonGenericIQuery_ShouldBuild()
    {
        // Setup
        const string customFieldName1 = "some-custom-field-name-1";

        var myQuery = A.Fake<IQuery>();
        A.CallTo(() => myQuery.QueryName).Returns(customFieldName1);
        A.CallTo(() => myQuery.AliasName).Returns(null);
        A.CallTo(() => myQuery.Build()).Returns(customFieldName1);

        var sut = new MetafieldQueryBuilder();
        sut.CreatedAt()
            .Id()
            .Key()
            .AddField(myQuery);

        // Act
        var result = sut.Build();

        // Assert
        result.Should().Contain(customFieldName1);
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenComplexFieldsAreAdded_ShouldBuildQueryWithSubquery()
    {
        // Setup
        var sut = new MetafieldQueryBuilder()
            .CreatedAt()
            .Id()
            .Key()
            .Definition(definitions => definitions
                .Id()
                .Name());

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    #region AddArguments

    [Fact]
    public async Task QueryBuilder_AddArgument_WhenArgumentsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ArticleTagsOperationQueryBuilder();
        sut.ReturnValue();
        sut.Arguments.Limit(10);

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddArgument_CustomKeyValueArgumentsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ArticleTagsOperationQueryBuilder();
        sut.ReturnValue();
        sut.Arguments.AddArgument("foo", 3);
        sut.Arguments.AddArgument("bar", true);
        sut.Arguments.AddArgument("baz", false);
        sut.Arguments.AddArgument("bat", 6.7);

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddArgument_WhenCustomDictionaryArgumentsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new ArticleTagsOperationQueryBuilder();
        sut = sut.ReturnValue();
        sut.Arguments.AddArguments(new Dictionary<string, object>
        {
            { "foo", 3 },
            { "bar", true },
            { "baz", false },
            { "bat", 6.7 }
        });

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    #region Unions

    [Fact]
    public async Task QueryBuilder_AddUnionCase_ShouldProduceGraphStringAddUnionCaseJoinAndExpectedFields()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        sut.Id()
            .CreatedAt()
            .Key()
            .Reference(reference =>
            {
                reference.OnCustomer(customer => customer.Id().DisplayName());
            });

        // Act
        var result = sut.Build();

        // Assert
        result.Should().ContainAll(
            "id",
            "createdAt",
            "key",
            "... on Customer{",
            "id",
            "displayName",
            "}"
        );
        await Verify(result, _verifySettings);
    }

    [Fact]
    public void QueryBuilder_AddUnionCase_ShouldAddTheTypeNameDiscriminator()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        sut.Id()
            .Reference(reference =>
            {
                reference.OnCustomer(customer => customer.Id().DisplayName());
            });

        // Act
        var result = sut.Build();

        // Assert
        result.Should().Contain("__typename");
    }

    [Fact]
    public void QueryBuilder_AddUnionCase_WhenAUnionTypeAddsMoreThanOneUnionCase_ShouldOnlyAddTheTypeNameDiscriminatorOnce()
    {
        // Setup
        const StringSplitOptions stringSplitOptions =
#if NET6_0_OR_GREATER
            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
#else
            StringSplitOptions.RemoveEmptyEntries
#endif
            ;

        var sut = new MetafieldQueryBuilder();
        sut.Id()
            .Reference(reference =>
            {
                reference.OnCustomer(customer => customer.Id().DisplayName());
                reference.OnCompany(company => company.Id().Name());
            });

        // Act
        var result = sut.Build();
        var queryWords = result.Split([' ', '}', '{'], stringSplitOptions);

        // Assert
        queryWords.Where(x => x == "__typename").Should().HaveCount(1);
    }


    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingMoreThanOneUnion_ShouldProduceGraphStringWithMultipleJoins()
    {
        // Setup
        var sut = new MetafieldQueryBuilder();
        sut.CreatedAt()
            .Id()
            .Key()
            .Reference(reference =>
            {
                reference.OnCustomer(customer => customer.Id().DisplayName());
                reference.OnCompany(company => company.Id().Name());
            });

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingCustomUnionTypes_ShouldBuild()
    {
        // Setup
        const string customUnionType = "some-custom-union-type";
        const string subFieldName = "some-sub-field-name";
        var query = new Query<CustomBat>($"... on {customUnionType}");
        query.AddField(subFieldName);

        var sut = new CustomThingQueryBuilderBase();
        sut.CreatedAt()
            .AddUnionCase(query);

        // Act
        var result = sut.Build();

        // Assert
        result.Should().ContainAll([
            "createdAt",
            $"... on {customUnionType}{{",
            "__typename",
            subFieldName,
        ]);
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingNestedUnionCases_ShouldProduceGraphStringWithNestedUnionCases()
    {
        // Setup
        const string innerUnionType = "some-custom-union-type";
        const string subFieldName = "some-sub-field-name";

        IQuery<CustomBat> innerUnion = new Query<CustomBat>($"... on {innerUnionType}");
        innerUnion = innerUnion.AddField(subFieldName);

        var sut = new MetafieldQueryBuilder();
        sut = sut.JsonValue()
            .CreatedAt()
            .Reference(reference =>
            {
                reference.OnCustomer(outerUnion => outerUnion
                    .Id()
                    .AddUnionCase(innerUnion));
            });

        // Act
        var result = sut.Build();

        // Assert
        result.Should().ContainAll(
            "createdAt",
            "jsonValue",
            "... on Customer{",
            "id",
            $"... on {innerUnionType}{{",
            "__typename",
            subFieldName
        );
        await Verify(result, _verifySettings);
    }

    #endregion

    #region Operations

    [Fact]
    public async Task QueryBuilder_WhenBuildingQueryOperations_ShouldWrapInAQueryBlock()
    {
        // Setup
        // Implements IGraphOperationQueryBuilder with OperationType.Query
        var sut = new ArticleTagsOperationQueryBuilder();
        sut = sut.ReturnValue();
        sut.Arguments.Limit(10);

        // Act
        var result = sut.Build();

        // Assert
        result.Should().StartWith("query {");
        result.Should().EndWith("}");
        result.Should().Contain("articleTags(limit:10)");
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenBuildingMutationOperations_ShouldWrapInAMutationBlock()
    {
        // Setup
        // Implements IGraphOperationQueryBuilder with OperationType.Mutation
        var sut = new ReturnCancelOperationQueryBuilder();
        sut = sut.Return(ret => ret.Id());

        // Act
        var result = sut.Build();

        // Assert
        result.Should().StartWith("mutation {");
        result.Should().EndWith("}");
        result.Should().Contain("returnCancel");
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenBuildingNestedQueries_ShouldNotWrap()
    {
        // Setup
        // Does NOT implement IGraphOperationQueryBuilder
        var sut = new MetafieldQueryBuilder();
        sut = sut.CreatedAt().Id().Key();

        // Act
        var result = sut.Build();

        // Assert
        result.Should().NotContain("query {");
        result.Should().NotContain("mutation {");
        result.Should().Be("metafield{createdAt id key}");
        await Verify(result, _verifySettings);
    }

    #endregion

    // Test helper classes - minimal implementations for testing custom query builders
    public class CustomThingQueryBuilderBase : QueryBuilderBase<CustomThing, CustomThingQueryBuilderBase>
    {
        protected override CustomThingQueryBuilderBase Self => this;

        public CustomThingQueryBuilderBase() : this("customThing")
        {
        }

        public CustomThingQueryBuilderBase(string name) : base(new Query<CustomThing>(name))
        {
        }

        public CustomThingQueryBuilderBase CreatedAt()
        {
            InnerQuery.AddField("createdAt");
            return this;
        }

        public CustomThingQueryBuilderBase AddUnionCase<TUnionCase>(IQuery<TUnionCase> query) where TUnionCase : class
        {
            InnerQuery.AddUnionCase(query);
            return this;
        }
    }

    public class CustomThing : IGraphQLObject;
    public class CustomBat : IGraphQLUnionCase, IGraphQLObject;
}
