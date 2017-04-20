using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Blog")]
    public class Blog_Tests : IAsyncLifetime
    {
        private BlogService _Service => new BlogService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Blog> _CreatedBlogs => new List<Blog>();

        private string _Title => "ShopifySharp Test Blog";

        private string _Commentable => "moderate";

        public Blog_Tests()
        {

        }

        public async Task InitializeAsync()
        {
            // Create one blog for methods like count, get, list, etc.
            await CreateBlog();
        }

        public async Task DisposeAsync()
        {
            foreach (var blog in _CreatedBlogs)
            {
                try
                {
                    await _Service.DeleteAsync(blog.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Blog with id {blog.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Blog> CreateBlog(bool skipAddToCreatedList = false)
        {
            var blog = await _Service.CreateAsync(new Blog()
            {
                Title = $"{_Title} #{Guid.NewGuid()}",
                Commentable = _Commentable,
            });

            if (! skipAddToCreatedList)
            {
                _CreatedBlogs.Add(blog);
            }

            return blog;
        }

        [Fact]
        public async Task Counts_Blogs()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Blogs()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Gets_Blogs()
        {
            var id = _CreatedBlogs.First().Id.Value;
            var blog = await _Service.GetAsync(id);

            Assert.True(blog.Id.HasValue);
            Assert.StartsWith(_Title, blog.Title);
            Assert.Equal(blog.Commentable, _Commentable);
        }

        [Fact]
        public async Task Deletes_Blogs()
        {
            var created = await CreateBlog(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Blogs)} threw exception. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Creates_Blogs()
        {
            var created = await CreateBlog();

            Assert.NotNull(created);
            Assert.StartsWith(_Title, created.Title);
            Assert.Equal(_Commentable, created.Commentable);
        }

        [Fact]
        public async Task Updates_Blogs()
        {
            var created = await CreateBlog();

            created.Commentable = "yes";

            var updated = await _Service.UpdateAsync(created);

            Assert.Equal("yes", created.Commentable);
        }
    }
}
