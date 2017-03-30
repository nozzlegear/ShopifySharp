using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyProductVariantService_Tests
{
    [Subject(typeof(ShopifyProductVariantService))]
    class When_creating_product_variants
    {
        Establish context = () =>
        {
            ProductId = VariantUtils.GetProductId().Await();
        };

        Because of = () =>
        {
            Variant = VariantUtils.Service.CreateAsync(ProductId, VariantUtils.CreateVariant()).Await();
        };

        It should_create_a_product_variant = () =>
        {
            Variant.ShouldNotBeNull();
            Variant.Id.HasValue.ShouldBeTrue();
            Variant.Option1.ShouldEqual(VariantUtils.Option1);
            Variant.Price.ShouldEqual(VariantUtils.Price);
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
    }
}
