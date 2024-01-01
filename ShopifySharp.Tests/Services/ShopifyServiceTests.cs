using System;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Tests.TestClasses;
using Xunit;

namespace ShopifySharp.Tests.Services;

[Trait("Category", "ShopifyService")]
[TestSubject(typeof(ShopifyService))]
public class ShopifyServiceTests
{
    #region PrepareRequest(string path) and BuildRequestUri

    [Fact]
    public void BuildRequestUri_ShouldReturnOverridenUri()
    {
        // Setup
        var expectedUri = new Uri("https://some-expected-uri.com", UriKind.Absolute);
        var service = new TestBuildRequestUriShopifyService(expectedUri);

        // Act
        var result = service.BuildRequestUriProxy();

        // Assert
        result.ToUri().Should().Be(expectedUri);
    }

    #endregion
}
