using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyDiscountService_Tests
{
    [Subject(typeof(ShopifyDiscountService)), Ignore("Shopify Discount API requires a Shopify Plus account, which is difficult to use when testing a lib.")]
    class When_creating_a_discount
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Discount = DiscountUtils.Service.CreateAsync(new ShopifyDiscount()
            {
                DiscountType = "fixed_amount",
                Value = "10.00",
                DiscountCode = "AuntieDot",
                MinimumOrderAmount = "40.00",
            }).Await().AsTask.Result;
        };

        It should_create_a_discount = () =>
        {
            Discount.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            if (Discount != null)
            {
                DiscountUtils.Service.DeleteAsync(Discount.Id.Value).Await();
            }
        };

        static ShopifyDiscount Discount { get; set; }
    }
}
