using Machine.Specifications;
using System;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    [Subject(typeof(BlogService))]
    public class When_deleting_a_blog
    {
        Establish context = () =>
        {
            Id = BlogUtils.Service.CreateAsync(BlogUtils.CreateBlog(), BlogUtils.CreateMeta()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Ex = Catch.Exception(() => BlogUtils.Service.DeleteAsync(Id.Value).Await());
        };

        It should_delete_a_blog = () =>
        {
            Ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {
            
        };

        static long? Id;

        static Exception Ex;
    }
}
