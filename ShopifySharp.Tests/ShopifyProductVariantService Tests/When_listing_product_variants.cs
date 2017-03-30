using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyProductVariantService_Tests
{
    [Subject(typeof(ProductVariantService))]
    class When_listing_product_variants
    {
        Establish context = () =>
        {
            ProductId = VariantUtils.GetProductId().Await();
            VariantId = VariantUtils.Service.CreateAsync(ProductId, VariantUtils.CreateVariant()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Variants = VariantUtils.Service.ListAsync(ProductId).Await().AsTask.Result;
        };

        It should_list_product_variants = () =>
        {
            Variants.ShouldNotBeNull();
            Variants.Count().ShouldBeGreaterThanOrEqualTo(1);
            Variants.ShouldEachConformTo(v => v.Id.HasValue);
            Variants.Any(v => v.Option1.Equals(VariantUtils.Option1) && v.Price.Equals(VariantUtils.Price)).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            VariantUtils.Service.DeleteAsync(ProductId, VariantId).Await();
        };

        static IEnumerable<ProductVariant> Variants;

        static long ProductId;

        static long VariantId;
    }
}
