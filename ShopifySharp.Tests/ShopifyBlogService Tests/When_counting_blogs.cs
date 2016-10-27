using Machine.Specifications;
using System.Collections.Generic;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    [Subject(typeof(ShopifyBlogService))]
    public class When_counting_a_blog
    {
        Establish context = () =>
        {
            Id = BlogUtils.Service.CreateAsync(BlogUtils.CreateBlog(), BlogUtils.CreateMeta()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Count = BlogUtils.Service.CountAsync().Await();
        };

        It should_count_a_blog = () =>
        {
            Count.HasValue.ShouldBeTrue();
            Count.ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            if (Id.HasValue)
            {
                BlogUtils.Service.DeleteAsync(Id.Value).Await();
            }
        };

        static long? Id;

        static int? Count;
    }
}
