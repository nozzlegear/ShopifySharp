using Machine.Specifications;
using System.Collections.Generic;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    [Subject(typeof(BlogService))]
    public class When_updating_a_blog
    {
        Establish context = () =>
        {
            Blog = BlogUtils.Service.CreateAsync(BlogUtils.CreateBlog(), BlogUtils.CreateMeta()).Await();
        };

        Because of = () =>
        {
            Blog.Commentable = "yes";
            Blog = BlogUtils.Service.UpdateAsync(Blog, new List<MetaField>()
            {
                new MetaField()
                {
                    Key = "new-field",
                    Value = "new-field-value",
                    ValueType = "string",
                    Namespace = "global"
                }
            }).Await();
        };

        It should_update_a_blog = () =>
        {
            Blog.ShouldNotBeNull();
            Blog.Id.HasValue.ShouldBeTrue();
            Blog.Title.Contains(BlogUtils.Title).ShouldBeTrue();
            Blog.Commentable.ShouldEqual("yes");
        };

        Cleanup after = () =>
        {
            if (Blog != null)
            {
                BlogUtils.Service.DeleteAsync(Blog.Id.Value).Await();
            }
        };

        static Blog Blog;
    }
}
