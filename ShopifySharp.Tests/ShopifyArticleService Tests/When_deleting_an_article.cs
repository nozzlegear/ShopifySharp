using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ShopifyArticleService))]
    class When_deleting_an_article
    {
        Establish context = () =>
        {
            Id = ArticleUtils.Service.CreateAsync(ArticleUtils.GetBlogId(), ArticleUtils.CreateArticle()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            ex = Catch.Exception(() => ArticleUtils.Service.DeleteAsync(ArticleUtils.GetBlogId(), Id).Await());
        };

        It should_delete_an_article = () =>
        {
            ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {

        };

        static long Id;

        static Exception ex;
    }
}
