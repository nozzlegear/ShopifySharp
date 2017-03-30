using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    [Subject(typeof(ShopifyBlogService))]
    public class When_listing_blogs
    {
        Establish context = () =>
        {
            Id = BlogUtils.Service.CreateAsync(BlogUtils.CreateBlog(), BlogUtils.CreateMeta()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Blogs = BlogUtils.Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_blogs = () =>
        {
            Blogs.ShouldNotBeNull();
            Blogs.Count().ShouldBeGreaterThanOrEqualTo(1);
            Blogs.ShouldEachConformTo(blog => blog != null && blog.Id.HasValue && !string.IsNullOrEmpty(blog.Title) && !string.IsNullOrEmpty(blog.Commentable));
        };

        Cleanup after = () =>
        {
            if (Id.HasValue)
            {
                BlogUtils.Service.DeleteAsync(Id.Value).Await();
            }
        };

        static long? Id;

        static IEnumerable<Blog> Blogs;
    }
}
