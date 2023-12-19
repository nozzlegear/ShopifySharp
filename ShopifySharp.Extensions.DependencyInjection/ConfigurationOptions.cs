using ShopifySharp.Utilities;

namespace ShopifySharp.Extensions.DependencyInjection;

public record ShopifySharpUtilityOptions
{
    public IShopifyDomainUtility? DomainUtility { get; set; }
    public IShopifyOauthUtility? OauthUtility { get; set; }
    public IShopifyRequestValidationUtility? RequestValidationUtility { get; set; }
}
