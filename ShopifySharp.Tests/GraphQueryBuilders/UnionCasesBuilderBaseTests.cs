#nullable enable
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;

namespace ShopifySharp.Tests.GraphQueryBuilders;

[Trait("Category", "QueryBuilder")]
[TestSubject(typeof(UnionCasesBuilderBase<,>))]
public class UnionCasesBuilderBaseTests
{
    #region AddUnionCase Tests

    [Fact]
    public void AddUnionCase_WithValidQuery_ShouldCallInnerQueryAddUnionCase()
    {
        // Setup
        var mockQuery = A.Fake<IQuery<TestGraphObject>>();
        var mockUnionCaseQuery = A.Fake<IQuery<TestUnionCase>>();

        var sut = new TestUnionCasesBuilder(mockQuery);

        // Act
        sut.AddUnionCase(mockUnionCaseQuery);

        // Assert
        A.CallTo(() => mockQuery.AddUnionCase(mockUnionCaseQuery))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public void AddUnionCase_ShouldReturnSelf()
    {
        // Setup
        var mockQuery = A.Fake<IQuery<TestGraphObject>>();
        var mockUnionCaseQuery = A.Fake<IQuery<TestUnionCase>>();
        var sut = new TestUnionCasesBuilder(mockQuery);

        // Act
        var result = sut.AddUnionCase(mockUnionCaseQuery);

        // Assert
        result.Should().BeSameAs(sut, "AddUnionCase should return Self for fluent chaining");
    }

    [Fact]
    public void AddUnionCase_WhenCalledMultipleTimes_ShouldChainFluently()
    {
        // Setup
        var mockQuery = A.Fake<IQuery<TestGraphObject>>();
        var mockUnionCase1 = A.Fake<IQuery<TestUnionCase>>();
        var mockUnionCase2 = A.Fake<IQuery<TestUnionCase>>();
        var mockUnionCase3 = A.Fake<IQuery<TestUnionCase>>();
        var sut = new TestUnionCasesBuilder(mockQuery);

        // Act
        var result = sut
            .AddUnionCase(mockUnionCase1)
            .AddUnionCase(mockUnionCase2)
            .AddUnionCase(mockUnionCase3);

        // Assert
        result.Should().BeSameAs(sut);
        A.CallTo(() => mockQuery.AddUnionCase(A<IQuery<TestUnionCase>>._))
            .MustHaveHappened(3, Times.Exactly);
    }

    [Fact]
    public void AddUnionCase_ShouldNotModifyQuery()
    {
        // Adding a union case should only delegate, it shouldn't modify the query
        // Setup
        var mockQuery = A.Fake<IQuery<TestGraphObject>>();
        var mockUnionCaseQuery = A.Fake<IQuery<TestUnionCase>>();

        var sut = new TestUnionCasesBuilder(mockQuery);

        // Act
        sut.AddUnionCase(mockUnionCaseQuery);

        // Assert
        // InnerQuery should still the same reference
        sut.GetInnerQuery().Should().BeSameAs(mockQuery, "InnerQuery should not be modified");
    }

    [Fact]
    public void AddUnionCase_WithDifferentUnionCaseType_ShouldWork()
    {
        // Setup
        var mockQuery = A.Fake<IQuery<TestGraphObject>>();
        var mockUnionCase = A.Fake<IQuery<AnotherTestUnionCase>>();
        var sut = new TestUnionCasesBuilder(mockQuery);

        // Act
        var act = () => sut.AddUnionCase(mockUnionCase);

        // Assert
        act.Should().NotThrow("AddUnionCase should support different TUnionCase types");
        A.CallTo(() => mockQuery.AddUnionCase(mockUnionCase))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public void AddUnionCase_WithNullQuery_ShouldPassNullToInnerQuery()
    {
        // Setup
        var mockQuery = A.Fake<IQuery<TestGraphObject>>();
        var sut = new TestUnionCasesBuilder(mockQuery);

        // Act
        var act = () => sut.AddUnionCase<TestUnionCase>(null!);

        // Assert
        // UnionCasesBuilderBase doesn't validate, it just delegates
        act.Should().NotThrow("validation is the responsibility of the underlying query");
        A.CallTo(() => mockQuery.AddUnionCase<TestUnionCase>(null!))
            .MustHaveHappenedOnceExactly();
    }

    #endregion

    #region Test Helpers

    public class TestUnionCasesBuilder(IQuery<TestGraphObject> query)
        : UnionCasesBuilderBase<TestGraphObject, TestUnionCasesBuilder>(query)
    {
        protected override TestUnionCasesBuilder Self => this;

        public IQuery<TestGraphObject> GetInnerQuery() => InnerQuery;
    }

    public class TestGraphObject : IGraphQLObject;

    public class TestUnionCase : IGraphQLUnionCase, IGraphQLObject;

    public class AnotherTestUnionCase : IGraphQLUnionCase, IGraphQLObject;

    #endregion
}
