using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ShopifyArticleService))]
    class When_listing_tags_for_a_blog
    {
        Establish context = () =>
        {
            CreatedId = ArticleUtils.Service.CreateAsync(ArticleUtils.GetBlogId(), ArticleUtils.CreateArticle()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Tags = ArticleUtils.Service.ListTagsForBlogAsync(ArticleUtils.GetBlogId()).Await().AsTask.Result;
        };

        It should_list_tags_for_a_blog = () =>
        {
            Tags.ShouldNotBeNull();
            Tags.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            if (CreatedId.HasValue)
            {
                ArticleUtils.Service.DeleteAsync(ArticleUtils.GetBlogId(), CreatedId.Value).Await();
            }
        };

        static long? CreatedId;

        static IEnumerable<string> Tags;
    }
}
