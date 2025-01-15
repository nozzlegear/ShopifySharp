#nullable enable
using System;
using System.Collections.Generic;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Services.Graph;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure;

[Trait("Category", "Infrastructure"), TestSubject(typeof(ShopifyGraphErrorsException))]
public class ShopifyGraphErrorsExceptionTests
{
    private const string GenericExceptionMessage = "GraphQL operation returned one or more errors.";

    private static IReadOnlyList<GraphError> CreateErrors(Action<GraphError, GraphErrorExtensions>? customize = null)
    {
        var list = new List<GraphError>();
        var userError = new GraphError
        {
            Message = "some-message",
            Extensions = new GraphErrorExtensions
            {
                Code = "some-code",
            }
        };
        customize?.Invoke(userError, userError.Extensions);
        list.Add(userError);

        return list;
    }

    [Fact]
    public void WhenErrorsListIsEmpty_ItShouldUseAGenericExceptionMessage()
    {
        // Setup
        const string expectedRequestId = "some-request-id";

        // Act
        var exn = new ShopifyGraphErrorsException([], expectedRequestId);

        // Assert
        exn.Message.Should().Be(GenericExceptionMessage);
        exn.RequestId.Should().Be(expectedRequestId);
    }

    [Fact]
    public void WhenErrorsListIsNotEmpty_ItShouldCreateAnExceptionMessageFromTheFirstErrorCodeAndMessage()
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        const string expectedCode = "some-expected-code";
        const string expectedMessage = "some-expected-message";
        var userErrors = CreateErrors((err, ex) =>
        {
            err.Message = expectedMessage;
            ex.Code = expectedCode;
        });

        // Act
        var exn = new ShopifyGraphErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be($"{expectedCode}: {expectedMessage}");
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphErrors.Should().HaveCount(1).And.AllSatisfy(x =>
        {
            x.Message.Should().Be(expectedMessage);
            x.Extensions.Should().BeEquivalentTo(new GraphErrorExtensions
            {
                Code = expectedCode
            });
        });
    }

    [Theory]
    [CombinatorialData]
    public void WhenErrorsListIsNotEmpty_AndTheFirstErrorHasAnEmptyMessage_AndTheFirstErrorHasANonEmptyCode_ItShouldCreateAnExceptionMessageFromTheFirstCode(
        [CombinatorialValues(null, "")] string? expectedMessageValue
    )
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        const string expectedCode = "some-expected-code";
        var userErrors = CreateErrors((err, ex) =>
        {
            err.Message = expectedMessageValue!;
            ex.Code = expectedCode;
        });

        // Act
        var exn = new ShopifyGraphErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be($"{expectedCode}: ");
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphErrors.Should().HaveCount(1).And.AllSatisfy(x =>
        {
            x.Message.Should().Be(expectedMessageValue);
            x.Extensions.Should().BeEquivalentTo(new GraphErrorExtensions
            {
                Code = expectedCode
            });
        });
    }

    [Theory]
    [CombinatorialData]
    public void WhenErrorsListIsNotEmpty_AndTheFirstErrorHasANonEmptyMessage_AndTheFirstErrorHasAnEmptyCode_ItShouldCreateAnExceptionMessageFromTheFirstMessage(
        [CombinatorialValues(null, "")] string? expectedCodeValue
    )
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        const string expectedMessage = "some-expected-message";
        var userErrors = CreateErrors((err, ex) =>
        {
            err.Message = expectedMessage;
            ex.Code = expectedCodeValue!;
        });

        // Act
        var exn = new ShopifyGraphErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be(expectedMessage, "the exception should use the first error's message value as the exception message");
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphErrors.Should().HaveCount(1).And.AllSatisfy(x =>
        {
            x.Message.Should().Be(expectedMessage);
            x.Extensions.Should().BeEquivalentTo(new GraphErrorExtensions
            {
                Code = expectedCodeValue!
            });
        });
    }

    [Theory]
    [CombinatorialData]
    public void WhenErrorsListIsNotEmpty_AndTheFirstErrorHasAnEmptyMessage_AndTheFirstErrorHasAnEmptyCode_ItShouldUseAGenericExceptionMessage(
        [CombinatorialValues(null, "")] string? expectedMessageValue,
        [CombinatorialValues(null, "")] string? expectedCodeValue
    )
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        var userErrors = CreateErrors((err, ex) =>
        {
            err.Message = expectedMessageValue!;
            ex.Code = expectedCodeValue!;
        });

        // Act
        var exn = new ShopifyGraphErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be(GenericExceptionMessage);
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphErrors.Should().HaveCount(1).And.AllSatisfy(x =>
        {
            x.Message.Should().Be(expectedMessageValue);
            x.Extensions.Should().BeEquivalentTo(new GraphErrorExtensions
            {
                Code = expectedCodeValue!
            });
        });
    }
}
