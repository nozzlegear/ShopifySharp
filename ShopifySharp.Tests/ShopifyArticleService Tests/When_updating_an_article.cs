using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ArticleService))]
    class When_updating_an_article
    {
        Establish context = () =>
        {
            Article = ArticleUtils.Service.CreateAsync(ArticleUtils.GetBlogId(), ArticleUtils.CreateArticle()).Await();
        };

        Because of = () =>
        {
            Article.BodyHtml = Html;
            Article = ArticleUtils.Service.UpdateAsync(ArticleUtils.GetBlogId(), Article).Await();
        };

        It should_update_an_article = () =>
        {
            Article.Id.HasValue.ShouldBeTrue();
            Article.BodyHtml.ShouldEqual(Html);
            Article.Author.ShouldEqual(ArticleUtils.Author);
            Article.BlogId.ShouldEqual(ArticleUtils.GetBlogId());
            Article.Title.ShouldContain(ArticleUtils.Title);
            Article.Handle.ShouldNotBeEmpty();
            Article.Tags.ShouldNotBeEmpty();
        };

        Cleanup after = () =>
        {
            if (Article != null)
            {
                ArticleUtils.Service.DeleteAsync(ArticleUtils.GetBlogId(), Article.Id.Value).Await();
            }
        };

        static Article Article;

        static string Html = "<h1>Updated!</h1>";
    }
}
