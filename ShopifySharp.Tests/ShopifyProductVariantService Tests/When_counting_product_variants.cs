using Machine.Specifications;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyProductVariantService_Tests
{
    [Subject(typeof(ProductVariantService))]
    class When_counting_product_variants
    {
        Establish context = () =>
        {
            ProductId = VariantUtils.GetProductId().Await();
        };

        Because of = () =>
        {
            Count = VariantUtils.Service.CountAsync(ProductId).Await();
        };

        It should_count_product_variants = () =>
        {
            Count.HasValue.ShouldBeTrue();
        };

        Cleanup after = () =>
        {

        };

        static int? Count;

        static long ProductId;
    }
}
