using System;
using System.Collections.Generic;

namespace ShopifySharp.Tests.ShopifyBlogService_Tests
{
    static class BlogUtils
    {
        public static ShopifyBlogService Service = new ShopifyBlogService(Utils.MyShopifyUrl, Utils.AccessToken);

        /// <summary>
        /// The title use in <see cref="ShopifyBlog"/>s created by <see cref="CreateBlog"/>. Note that the method will also append a random guid to the end of the title.
        /// </summary>
        public static string Title = "ShopifySharp Test Blog";        

        public static string Commentable = "moderate";

        /// <summary>
        /// Creates a valid <see cref="ShopifyBlog"/>.
        /// </summary>
        public static ShopifyBlog CreateBlog()
        {
            return new ShopifyBlog()
            {
                Title = $"{Title} #{Guid.NewGuid()}",
                Commentable = Commentable
            };
        }

        /// <summary>
        /// Creates metafields for creating and updating a blog.
        /// </summary>
        public static List<ShopifyMetaField> CreateMeta()
        {
            return new List<ShopifyMetaField>()
            {
                new ShopifyMetaField()
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
