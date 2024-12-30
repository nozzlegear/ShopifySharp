#nullable enable
using System;
using System.Collections.Generic;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Graph;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure;

[Trait("Category", "Infrastructure"), TestSubject(typeof(ShopifyGraphUserErrorsException))]
public class ShopifyGraphUserErrorsExceptionTests
{
    private const string GenericExceptionMessage = "GraphQL operation returned one or more errors.";

    private static ICollection<GraphUserError> CreateErrors(Action<GraphUserError>? customize = null)
    {
        var list = new List<GraphUserError>();
        var userError = new GraphUserError
        {
            Code = "some-code",
            Field = ["some-field"],
            Message = "some-message"
        };
        customize?.Invoke(userError);
        list.Add(userError);

        return list;
    }

    [Fact]
    public void WhenUserErrorsListIsEmpty_ItShouldUseAGenericExceptionMessage()
    {
        // Setup
        const string expectedRequestId = "some-request-id";

        // Act
        var exn = new ShopifyGraphUserErrorsException([], expectedRequestId);

        // Assert
        exn.Message.Should().Be(GenericExceptionMessage);
        exn.RequestId.Should().Be(expectedRequestId);
    }

    [Fact]
    public void WhenUserErrorsListIsNotEmpty_ItShouldCreateAnExceptionMessageFromTheFirstErrorCodeAndMessage()
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        const string expectedCode = "some-expected-code";
        const string expectedMessage = "some-expected-message";
        string[] expectedFields = ["some-field"];
        var userErrors = CreateErrors(x =>
        {
            x.Code = expectedCode;
            x.Message = expectedMessage;
            x.Field = expectedFields;
        });

        // Act
        var exn = new ShopifyGraphUserErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be($"{expectedCode}: {expectedMessage}");
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphUserErrors.Should().Satisfy(x => x.Message == expectedMessage && x.Code == expectedCode && x.Field == expectedFields);
    }

    [Theory]
    [CombinatorialData]
    public void WhenUserErrorsListIsNotEmpty_AndTheFirstErrorHasAnEmptyMessage_AndTheFirstErrorHasANonEmptyCode_ItShouldCreateAnExceptionMessageFromTheFirstCode(
        [CombinatorialValues(null, "")] string? expectedMessageValue
    )
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        const string expectedCode = "some-expected-code";
        string[] expectedFields = ["some-field"];
        var userErrors = CreateErrors(x =>
        {
            x.Code = expectedCode;
            x.Message = expectedMessageValue!;
            x.Field = expectedFields;
        });

        // Act
        var exn = new ShopifyGraphUserErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be($"{expectedCode}: ");
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphUserErrors.Should().Satisfy(x => x.Message == expectedMessageValue && x.Code == expectedCode && x.Field == expectedFields);
    }

    [Theory]
    [CombinatorialData]
    public void WhenUserErrorsListIsNotEmpty_AndTheFirstErrorHasANonEmptyMessage_AndTheFirstErrorHasAnEmptyCode_ItShouldCreateAnExceptionMessageFromTheFirstMessage(
        [CombinatorialValues(null, "")] string? expectedCodeValue
    )
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        const string expectedMessage = "some-expected-message";
        string[] expectedFields = ["some-field"];
        var userErrors = CreateErrors(x =>
        {
            x.Code = expectedCodeValue;
            x.Message = expectedMessage;
            x.Field = expectedFields;
        });

        // Act
        var exn = new ShopifyGraphUserErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be(expectedMessage, "the exception should use the first error's message value as the exception message");
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphUserErrors.Should().Satisfy(x => x.Message == expectedMessage && x.Code == expectedCodeValue && x.Field == expectedFields);
    }

    [Theory]
    [CombinatorialData]
    public void WhenUserErrorsListIsNotEmpty_AndTheFirstErrorHasAnEmptyMessage_AndTheFirstErrorHasAnEmptyCode_ItShouldUseAGenericExceptionMessage(
        [CombinatorialValues(null, "")] string? expectedMessageValue,
        [CombinatorialValues(null, "")] string? expectedCodeValue
    )
    {
        // Setup
        const string expectedRequestId = "some-request-id";
        string[] expectedFields = ["some-field"];
        var userErrors = CreateErrors(x =>
        {
            x.Code = expectedCodeValue;
            x.Message = expectedMessageValue!;
            x.Field = expectedFields;
        });

        // Act
        var exn = new ShopifyGraphUserErrorsException(userErrors, expectedRequestId);

        // Assert
        exn.Message.Should().Be(GenericExceptionMessage);
        exn.RequestId.Should().Be(expectedRequestId);
        exn.GraphUserErrors.Should().Satisfy(x => x.Message == expectedMessageValue && x.Code == expectedCodeValue && x.Field == expectedFields);
    }
}
