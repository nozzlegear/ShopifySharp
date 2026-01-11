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
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
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
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenMultipleFieldsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
        sut.Fields.Bar();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_MultipleFieldCalls_ShouldChainTogetherFluently()
    {
        // Setup
        var sut = new CustomThingQueryBuilder();
        sut.Fields
            .CreatedAt()
            .Bar();

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenCustomFieldsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
        sut.Fields.AddField("fooField");

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenComplexFieldsAreAdded_ShouldBuildQueryWithSubquery()
    {
        // Setup
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
        sut.Fields.Baz(x =>
        {
            x.Fields
                .Foo()
                .Bar()
                .Bat();
        });

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
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
        sut.Arguments.Foo("bar");

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddArgument_CustomKeyValueArgumentsAreAdded_ShouldBuild()
    {
        // Setup
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
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
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
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
    public async Task QueryBuilder_AddUnionCase_ShouldProduceGraphStringWithUnionCaseJoinAndExpectedFields()
    {
        // Setup
        var sut = new CustomThingQueryBuilder();
        sut.Fields.CreatedAt();
        sut.Unions.OnCustomBaz((MoneyV2QueryBuilder x) => x.Fields.Amount());

        // Act
        var result = sut.Build();

        // Assert
        result.Should().ContainAll([
            "value{",
            "... on MoneyV2{",
            "__typename",
            "amount"
        ]);
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingMoreThanOneUnion_ShouldProduceGraphStringWithMultipleJoins()
    {
        // Setup
        var sut = new MetafieldRelationQueryBuilder();
        sut.Fields
            .Name()
            .Namespace();
        sut.Fields.Referencer(builder =>
        {
            builder.OnArticle(article => article.Fields.Id());
            builder.OnBlog(blog => blog.Fields.Tags());
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
        var sut = new CalculatedDiscountCodeApplicationQueryBuilder();
        sut.Fields.Code();
        sut.Fields.Value(builder =>
            {
                builder.OnSubscriptionDiscountFixedAmountValue(fixedAmount => fixedAmount.Fields.Amount(money => money.Fields.Amount()));
                sut.AddUnionCase<CustomThing, CustomThingQueryBuilder>("myCustomThing", "DineroV2", x => x.AddFoo());
            }
        );

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_AddUnionCase_WhenAddingNestedUnionCases_ShouldProduceGraphStringWithNestedUnionCases()
    {
        // Setup
        var sut = new CalculatedDiscountCodeApplicationQueryBuilder();
        sut.Fields.Code();
        sut.AddUnionCase<CustomThing, CustomThingQueryBuilder>("myCustomThing", "DineroV2", builder =>
        {
            builder.AddFoo();
            builder.AddUnionCase<CustomThing, CustomThingQueryBuilder>("myNestedCustomThing", "NestedDineroV2", builder2 =>
            {
                builder2.AddFoo();
                return builder2;
            });
            return builder;
        });

        // Act
        var result = sut.Build();

        // Assert
        await Verify(result, _verifySettings);
    }

    #endregion

    public class CustomThingQueryBuilder : GraphQueryBuilder<CustomThing>
    {
        public readonly CustomThingArgumentsBuilder Arguments;
        public readonly CustomThingFieldsBuilder Fields;
        public readonly CustomThingUnionCasesBuilder Unions;

        public CustomThingQueryBuilder(): base("customThing")
        {
            Arguments = new CustomThingArgumentsBuilder(Query);
            Fields = new CustomThingFieldsBuilder(Query);
            Unions = new CustomThingUnionCasesBuilder(Query);
        }
    }

    public class CustomThingArgumentsBuilder(IQuery<CustomThing> query)
        : ArgumentsBuilderBase<CustomThing>(query)
    {
        public CustomThingArgumentsBuilder Foo(string value)
        {
            return AddArgumentX<CustomThingArgumentsBuilder>("foo", value);
            // Query.AddArgument("foo", value);
            // return this;
        }
    }

    public class CustomThingFieldsBuilder(IQuery<CustomThing> query)
        : FieldsBuilderBase<CustomThing>(query)
    {
        public CustomThingFieldsBuilder CreatedAt()
        {
            Query.AddField("createdAt");
            return this;
        }

        public CustomThingFieldsBuilder Bar()
        {
            Query.AddField("bar");
            return this;
        }

        public CustomThingFieldsBuilder Baz(Action<CustomBazQueryBuilder> build)
        {
            var builder = new CustomBazQueryBuilder("baz");
            build.Invoke(builder);
            Query.AddField(builder.Query);
            return this;
        }
    }

    public class CustomThingUnionCasesBuilder(IQuery<CustomThing> query)
        : UnionCaseBuilderBase<CustomThing>(query)
    {
        public CustomThingUnionCasesBuilder OnCustomBaz(Action<CustomBazQueryBuilder> build)
        {
            var queryBuilder = new CustomBazQueryBuilder("... on CustomBaz");
            Query.AddUnionCase("bar", queryBuilder.Query);
            return this;
        }
    }

    public class CustomThing : IGraphQLObject;

    public class CustomBaz : IGraphQLUnionCase, IGraphQLObject;

    public class CustomBazFieldsBuilder(IQuery<CustomBaz> query) : FieldsBuilderBase<CustomBaz>(query)
    {
        public CustomBazFieldsBuilder Foo()
        {
            AddField("foo");
            return this;
        }

        public CustomBazFieldsBuilder Bar()
        {
            AddField("baz");
            return this;
        }

        public CustomBazFieldsBuilder Bat()
        {
            AddField("bat");
            return this;
        }
    }

    public class CustomBazQueryBuilder : GraphQueryBuilder<CustomBaz>
    {
        public readonly CustomBazFieldsBuilder Fields;

        public CustomBazQueryBuilder(string name) : base(new Query<CustomBaz>(name))
        {
            Fields = new CustomBazFieldsBuilder(Query);
        }
    }
}
