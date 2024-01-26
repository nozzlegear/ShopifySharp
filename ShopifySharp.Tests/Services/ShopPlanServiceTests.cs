using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using Xunit;

namespace ShopifySharp.Tests.Services;

[Trait("Category", "ShopPlanService")]
[TestSubject(typeof(ShopPlanService))]
public class ShopPlanServiceTests
{
    ShopPlanService service = new(Utils.MyShopifyUrl, Utils.AccessToken);

    [Fact]
    public async Task GetShopPlanAsync_ShouldGetThePlanAsync()
    {
        // Act
        var result = await service.GetShopPlanAsync();

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
        var result = await service.IsPartnerDevelopmentShopAsync();

        // Assert
        result.Should().BeTrue();
    }
}
