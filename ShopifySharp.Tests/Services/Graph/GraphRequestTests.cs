using System.Collections.Generic;
using FluentAssertions;
using JetBrains.Annotations;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;


[Trait("Category", "GraphRequest"), TestSubject(typeof(GraphRequest))]
public class GraphRequestTests
{
    [Fact]
    public void Setters_ShouldSetNonObsoletedQueryValue()
    {
        // Setup
        const string expectedQuery = "some-expected-query";
        var request = new GraphRequest
        {
            Query = ""
        };

        // Act
#pragma warning disable CS0618 // Type or member is obsolete
        request.query = expectedQuery;
#pragma warning restore CS0618 // Type or member is obsolete

        // Assert
        request.Query.Should().Be(expectedQuery);
    }

    [Fact]
    public void Setters_WhenVariablesAreADictionary_ShouldSetNonObsoletedVariablesValue()
    {
        // Setup
        var expectedVariables = new Dictionary<string, object>
        {
            { "foo", "bar" },
            { "baz", true },
            { "bat", 7 }
        };
        var request = new GraphRequest
        {
            Variables = null
        };

        // Act
#pragma warning disable CS0618 // Type or member is obsolete
        request.variables = expectedVariables;
#pragma warning restore CS0618 // Type or member is obsolete

        // Assert
        request.Variables.Should().BeEquivalentTo(expectedVariables);
    }

    [Fact]
    public void Setters_WhenVariablesAreAnAnonymousObject_ShouldSetNonObsoletedVariablesValues()
    {
        // Setup
        var expectedVariables = new Dictionary<string, object>
        {
            { "foo", "bar" },
            { "baz", true },
            { "bat", 7 }
        };
        var request = new GraphRequest
        {
            Variables = null
        };

        // Act
#pragma warning disable CS0618 // Type or member is obsolete
        request.variables = new
        {
            foo = "bar",
            baz = true,
            bat = 7
        };
#pragma warning restore CS0618 // Type or member is obsolete

        // Assert
        request.Variables.Should().BeEquivalentTo(expectedVariables);
    }
}
