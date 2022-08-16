using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Article")]
    public class Article_Tests : IClassFixture<Article_Tests_Fixture>
    {
        private Article_Tests_Fixture Fixture { get; }

        public Article_Tests(Article_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Articles()
        {
            var count = await Fixture.Service.CountAsync(Fixture.BlogId.Value);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Creates_Articles()
        {
            var article = await Fixture.Create();

            Assert.True(article.Id.HasValue);
            Assert.Equal(Fixture.Author, article.Author);
            Assert.Equal(Fixture.BodyHtml, article.BodyHtml);
            Assert.Equal(Fixture.BlogId, article.BlogId);
            Assert.StartsWith(Fixture.Title, article.Title);
            EmptyAssert.NotNullOrEmpty(article.Handle);
            EmptyAssert.NotNullOrEmpty(article.Tags);
        }

        [Fact]
        public async Task Deletes_Articles()
        {
            var article = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(Fixture.BlogId.Value, article.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Articles)} threw exception. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Lists_Articles()
        {
            var articles = await Fixture.Service.ListAsync(Fixture.BlogId.Value);

            Assert.True(articles.Items.Count() > 0);
        }

        [Fact]
        public async Task Lists_Authors()
        {
            var authors = await Fixture.Service.ListAuthorsAsync();

            Assert.True(authors.Count() > 0);
            Assert.True(authors.Any(a => a == Fixture.Author));
        }

        [Fact]
        public async Task Lists_Tags()
        {
            var tags = await Fixture.Service.ListTagsAsync();

            Assert.True(tags.Count() > 0);
        }

        [Fact]
        public async Task Lists_Tags_For_Blog()
        {
            var tags = await Fixture.Service.ListTagsForBlogAsync(Fixture.BlogId.Value);

            Assert.True(tags.Count() > 0);
        }

        [Fact]
        public async Task Updates_Articles()
        {
            string html = "<h1>Updated!</h1>";
            var article = await Fixture.Create();
            long id = article.Id.Value;

            article.BodyHtml = html;
            article.Id = null;

            article = await Fixture.Service.UpdateAsync(Fixture.BlogId.Value, id, article);

            // Reset the id so the Fixture can properly delete this object.
            article.Id = id;

            Assert.Equal(article.BodyHtml, html);
        }
    }

    public class Article_Tests_Fixture : IAsyncLifetime
    {
        public ArticleService Service { get; } = new ArticleService(Utils.MyShopifyUrl, Utils.AccessToken);

        public BlogService BlogService { get; } = new BlogService(Utils.MyShopifyUrl, Utils.AccessToken);

        public string Title => "My new Article title - ";

        public string Author => "John Smith";

        public string Tags => "This Post, Has Been Tagged";

        public string BodyHtml => "<h1>I like articles</h1>\n<p><strong>Yea</strong>, I like posting them through <span class=\"caps\">REST</span>.</p>";

        public long? BlogId { get; set; }

        public List<Article> Created { get; } = new List<Article>();

        public async Task InitializeAsync()
        {
            var policy = new LeakyBucketExecutionPolicy();

            Service.SetExecutionPolicy(policy);
            BlogService.SetExecutionPolicy(policy);

            var blogs = await BlogService.ListAsync();

            BlogId = blogs.Items.First().Id;

            // Create at least one article for list, count, etc commands.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var article in Created)
            {
                try
                {
                    await Service.DeleteAsync(BlogId.Value, article.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete Article with id {article.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates the object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Article> Create(bool skipAddToDeleteList = false)
        {
            var obj = await Service.CreateAsync(BlogId.Value, new Article()
            {
                Title = Title + Guid.NewGuid(),
                Author = Author,
                Tags = Tags,
                BodyHtml = BodyHtml,
                Image = new ArticleImage()
                {
                    Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
                }
            });

            if (!skipAddToDeleteList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
