using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ShopifyArticleService))]
    class When_listing_articles
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Articles = ArticleUtils.Service.ListAsync(ArticleUtils.GetBlogId()).Await().AsTask.Result.ToList();
        };

        It should_list_articles = () =>
        {
            Articles.ShouldNotBeNull();
            Articles.Count().ShouldBeGreaterThanOrEqualTo(0);
        };

        Cleanup after = () =>
        {

        };

        static IEnumerable<ShopifyArticle> Articles;
    }
}
