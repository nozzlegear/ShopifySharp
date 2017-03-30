using Machine.Specifications;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    [Subject(typeof(ArticleService))]
    class When_listing_authors
    {
        Establish context = () =>
        {
            CreatedId = ArticleUtils.Service.CreateAsync(ArticleUtils.GetBlogId(), ArticleUtils.CreateArticle()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Authors = ArticleUtils.Service.ListAuthorsAsync().Await().AsTask.Result;
        };

        It should_list_authors = () =>
        {
            Authors.ShouldNotBeNull();
            Authors.Any(a => a == ArticleUtils.Author).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            if (CreatedId.HasValue)
            {
                ArticleUtils.Service.DeleteAsync(ArticleUtils.GetBlogId(), CreatedId.Value).Await();
            }
        };

        static long? CreatedId;

        static IEnumerable<string> Authors;
    }
}
