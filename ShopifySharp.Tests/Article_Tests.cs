using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Article")]
    public class ArticleUtils : IAsyncLifetime
    {
        private ArticleService _Service => new ArticleService(Utils.MyShopifyUrl, Utils.AccessToken);

        private string _Title => "My new Article title - ";

        private string _Author => "John Smith";

        private string _Tags => "This Post, Has Been Tagged";

        private string _BodyHtml => "<h1>I like articles</h1>\n<p><strong>Yea</strong>, I like posting them through <span class=\"caps\">REST</span>.</p>";

        private long? _BlogId { get; set; }

        private List<Article> _CreatedArticles => new List<Article>();

        public ArticleUtils()
        {

        }

        public async Task InitializeAsync()
        {
            var blogService = new BlogService(Utils.MyShopifyUrl, Utils.AccessToken);
            var blogs = await blogService.ListAsync();

            _BlogId = blogs.First().Id;

            // Create at least one article for list, count, etc commands.
            await CreateArticleAsync();
        }

        public async Task DisposeAsync()
        {
            foreach (var article in _CreatedArticles)
            {
                try
                {
                    await _Service.DeleteAsync(_BlogId.Value, article.Id.Value);
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
        /// Convenience function for running tests. Creates an article and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<Article> CreateArticleAsync(bool skipAddToDeleteList = false)
        {
            var article = await _Service.CreateAsync(_BlogId.Value, new Article()
            {
                Title = _Title + Guid.NewGuid(),
                Author = _Author,
                Tags = _Tags,
                BodyHtml = _BodyHtml,
                Image = new ArticleImage()
                {
                    Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
                }
            });

            if (! skipAddToDeleteList)
            {
                _CreatedArticles.Add(article);
            }

            return article;
        }

        [Fact]
        public async Task Counts_Articles()
        {
            var count = await _Service.CountAsync(_BlogId.Value);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Creates_Articles()
        {
            var article = await CreateArticleAsync();

            Assert.True(article.Id.HasValue);
            Assert.Equal(article.Author, _Author);
            Assert.Equal(article.BodyHtml, _BodyHtml);
            Assert.Equal(article.BlogId, _BlogId);
            Assert.Contains(article.Title, _Title);
            Assert.NotEmpty(article.Handle);
            Assert.NotEmpty(article.Tags);
        }

        [Fact]
        public async Task Deletes_Articles()
        {
            var article = await CreateArticleAsync(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(_BlogId.Value, article.Id.Value);
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
            var articles = await _Service.ListAsync(_BlogId.Value);

            Assert.True(articles.Count() > 0);
        }

        [Fact]
        public async Task Lists_Authors()
        {
            var authors = await _Service.ListAuthorsAsync();

            Assert.True(authors.Count() > 0);
            Assert.True(authors.Any(a => a == _Author));
        }

        [Fact]
        public async Task Lists_Tags()
        {
            var tags = await _Service.ListTagsAsync();
            
            Assert.True(tags.Count() > 0);
        }

        [Fact]
        public async Task Lists_Tags_For_Blog()
        {
            var tags = await _Service.ListTagsForBlogAsync(_BlogId.Value);

            Assert.True(tags.Count() > 0);
        }

        public async Task Updates_Articles()
        {
            string html = "<h1>Updated!</h1>";
            var article = await CreateArticleAsync();

            article.BodyHtml = html;
            article = await _Service.UpdateAsync(_BlogId.Value, article);

            Assert.Equal(article.BodyHtml, html);
        }
    }
}
