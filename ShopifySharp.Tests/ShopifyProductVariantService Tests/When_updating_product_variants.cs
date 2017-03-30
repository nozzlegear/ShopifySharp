using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyProductVariantService_Tests
{
    [Subject(typeof(ProductVariantService))]
    class When_updating_product_variants
    {
        Establish context = () =>
        {
            ProductId = VariantUtils.GetProductId().Await();
            Variant = VariantUtils.Service.CreateAsync(ProductId, VariantUtils.CreateVariant()).Await();
        };

        Because of = () =>
        {
            Variant.Price = UpdatedPrice;

            Variant = VariantUtils.Service.UpdateAsync(Variant).Await();
        };

        It should_update_a_product_variant = () =>
        {
            Variant.ShouldNotBeNull();
            Variant.Id.HasValue.ShouldBeTrue();
            Variant.Price.ShouldEqual(UpdatedPrice);
        };

        Cleanup after = () =>
        {
            if (Variant != null && Variant.Id.HasValue)
            {
                VariantUtils.Service.DeleteAsync(ProductId, Variant.Id.Value).Await();
            }
        };

        static ProductVariant Variant;

        static long ProductId;
        
        static double UpdatedPrice = 543.21;
    }
}
