using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    [Subject(typeof(ShopifyBlogService))]
    public class When_creating_a_blog
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Blog = BlogUtils.Service.CreateAsync(BlogUtils.CreateBlog(), BlogUtils.CreateMeta()).Await();
        };

        It should_create_a_blog = () =>
        {
            Blog.ShouldNotBeNull();
            Blog.Id.HasValue.ShouldBeTrue();
            Blog.Title.Contains(BlogUtils.Title).ShouldBeTrue();
            Blog.Commentable.ShouldEqual(BlogUtils.Commentable);
        };

        Cleanup after = () =>
        {
            if (Blog != null)
            {
                BlogUtils.Service.DeleteAsync(Blog.Id.Value).Await();
            }
        };

        static ShopifyBlog Blog;
    }
}
