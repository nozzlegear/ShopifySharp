using Machine.Specifications;
using System;

namespace ShopifySharp.Tests.ShopifyProductVariantService_Tests
{
    [Subject(typeof(ShopifyProductVariantService))]
    class When_deleting_a_product_variant
    {
        Establish context = () =>
        {
            ProductId = VariantUtils.GetProductId().Await();
            VariantId = VariantUtils.Service.CreateAsync(ProductId, VariantUtils.CreateVariant()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Ex = Catch.Exception(() => VariantUtils.Service.DeleteAsync(ProductId, VariantId));
        };

        It should_delete_a_product_variant = () =>
        {
            Ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {
            
        };

        static Exception Ex;

        static long ProductId;

        static long VariantId;
    }
}
