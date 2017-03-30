using System;
using System.Collections.Generic;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    static class BlogUtils
    {
        public static ShopifyBlogService Service = new ShopifyBlogService(Utils.MyShopifyUrl, Utils.AccessToken);

        /// <summary>
        /// The title use in <see cref="Blog"/>s created by <see cref="CreateBlog"/>. Note that the method will also append a random guid to the end of the title.
        /// </summary>
        public static string Title = "ShopifySharp Test Blog";        

        public static string Commentable = "moderate";

        /// <summary>
        /// Creates a valid <see cref="Blog"/>.
        /// </summary>
        public static Blog CreateBlog()
        {
            return new Blog()
            {
                Title = $"{Title} #{Guid.NewGuid()}",
                Commentable = Commentable
            };
        }

        /// <summary>
        /// Creates metafields for creating and updating a blog.
        /// </summary>
        public static List<ShopifySharp.MetaField> CreateMeta()
        {
            return new List<ShopifySharp.MetaField>()
            {
                new ShopifySharp.MetaField()
                {
                    Key = "new",
                    Value = "newvalue",
                    ValueType = "string",
                    Namespace = "global"
                }
            };
        }
    }
}
