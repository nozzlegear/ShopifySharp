using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using NSubstitute;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests.Services;

[Trait("Category", "ShopPlanService")]
[TestSubject(typeof(ShopPlanService))]
public class ShopPlanServiceTests
{
    private const string ExpectedShopPlanJson =
    """
    {
      "data" : {
        "shop" : {
          "plan" : {
            "displayName" : "Development",
            "partnerDevelopment" : true,
            "shopifyPlus" : false
          }
        }
      },
      "extensions" : {
        "cost" : {
          "requestedQueryCost" : 2,
          "actualQueryCost" : 2,
          "throttleStatus" : {
            "maximumAvailable" : 2000.0,
            "currentlyAvailable" : 1998,
            "restoreRate" : 100.0
          }
        }
      }
    }
    """;

    private readonly IRequestExecutionPolicy _policy = A.Fake<IRequestExecutionPolicy>();
    private readonly ShopPlanService _sut;

    public ShopPlanServiceTests()
    {
        _sut = new ShopPlanService(Utils.MyShopifyUrl, Utils.AccessToken, serviceProvider: null);
        _sut.SetExecutionPolicy(_policy);

        // Make the service's execution policy short circuit and actual HTTP calls
        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(MakeRequestResult(ExpectedShopPlanJson));
    }

    private static RequestResult<string> MakeRequestResult(string responseJson)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK);
        return new RequestResult<string>(
            "some-request-info",
            response.Headers,
            responseJson,
            responseJson,
            "some-raw-link-header-value",
            HttpStatusCode.OK
        );
    }

    [Fact]
    public async Task GetShopPlanAsync_ShouldGetThePlanAsync()
    {
        // Act
        var result = await _sut.GetShopPlanAsync();

        // Assert
        result.Should().NotBeNull();
        result.DisplayName.Should().NotBeNullOrEmpty();
        result.PartnerDevelopment.Should().BeTrue();
        result.ShopifyPlus.Should().BeFalse();
    }

    [Fact]
    public async Task IsPartnerDevelopmentPlanAsync_ShouldCheckIfTheShopIsOnADevPlan()
    {
        // Act
        var result = await _sut.IsPartnerDevelopmentShopAsync();

        // Assert
        result.Should().BeTrue();
    }
}
