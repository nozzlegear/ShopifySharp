using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ShopifyArticleService))]
    class When_counting_articles
    {
        Establish context = () =>
        {
            CreatedId = ArticleUtils.Service.CreateAsync(ArticleUtils.GetBlogId(), ArticleUtils.CreateArticle()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Count = ArticleUtils.Service.CountAsync(ArticleUtils.GetBlogId()).Await();
        };

        It should_count_articles = () =>
        {
            Count.HasValue.ShouldBeTrue();
            Count.Value.ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            if (CreatedId.HasValue)
            {
                ArticleUtils.Service.DeleteAsync(ArticleUtils.GetBlogId(), CreatedId.Value).Await();
            }
        };

        static int? Count;

        static long? CreatedId;
    }
}
