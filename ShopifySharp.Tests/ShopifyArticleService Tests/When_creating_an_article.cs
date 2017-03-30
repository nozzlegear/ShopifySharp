using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ShopifyArticleService))]
    class When_creating_an_article
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Article = ArticleUtils.Service.CreateAsync(ArticleUtils.GetBlogId(), ArticleUtils.CreateArticle()).Await();
        };

        It should_create_an_article = () =>
        {
            Article.Id.HasValue.ShouldBeTrue();
            Article.Author.ShouldEqual(ArticleUtils.Author);
            Article.BodyHtml.ShouldEqual(ArticleUtils.BodyHtml);
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
    }
}
