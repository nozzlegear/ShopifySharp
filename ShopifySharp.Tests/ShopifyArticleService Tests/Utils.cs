using System;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyArticleService_Tests
{
    static class ArticleUtils
    {
        public static ShopifyArticleService Service = new ShopifyArticleService(Utils.MyShopifyUrl, Utils.AccessToken);

        public static string Title = "My new Article title - ";

        public static string Author = "John Smith";

        public static string Tags = "This Post, Has Been Tagged";

        public static string BodyHtml = "<h1>I like articles</h1>\n<p><strong>Yea</strong>, I like posting them through <span class=\"caps\">REST</span>.</p>";

        static long? BlogId;
        
        public static long GetBlogId()
        {
            if (BlogId.HasValue)
            {
                return BlogId.Value;
            }

            var service = new ShopifyBlogService(Utils.MyShopifyUrl, Utils.AccessToken);
            var blogs = service.ListAsync().Result;

            BlogId = blogs.First().Id;

            return BlogId.Value;
        }

        public static Article CreateArticle()
        {
            return new Article()
            {
                Title = Title + Guid.NewGuid(),
                Author = Author,
                Tags = Tags,
                BodyHtml = BodyHtml,
                Image = new ArticleImage()
                {
                    Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
                }
            };
        }
    }
}
