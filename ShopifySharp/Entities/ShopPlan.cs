#nullable enable
namespace ShopifySharp;

///<summary>
///The billing plan of the shop.
///</summary>
public class ShopPlan
{
    ///<summary>
    ///The name of the shop's billing plan.
    ///</summary>
    public string? DisplayName { get; set; }
    ///<summary>
    ///Whether the shop is a partner development shop for testing purposes.
    ///</summary>
    public bool? PartnerDevelopment { get; set; }
    ///<summary>
    ///Whether the shop has a Shopify Plus subscription.
    ///</summary>
    public bool? ShopifyPlus { get; set; }
}
