using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    [Subject(typeof(ShopifyBlogService))]
    public class When_getting_a_blog
    {
        Establish context = () =>
        {
            Id = BlogUtils.Service.CreateAsync(BlogUtils.CreateBlog(), BlogUtils.CreateMeta()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Blog = BlogUtils.Service.GetAsync(Id.Value).Await();
        };

        It should_get_a_blog = () =>
        {
            Blog.ShouldNotBeNull();
            Blog.Id.HasValue.ShouldBeTrue();
            Blog.Title.Contains(BlogUtils.Title).ShouldBeTrue();
            Blog.Commentable.ShouldEqual(BlogUtils.Commentable);
        };

        Cleanup after = () =>
        {
            if (Id.HasValue)
            {
                BlogUtils.Service.DeleteAsync(Id.Value).Await();
            }
        };

        static long? Id;

        static Blog Blog;
    }
}
