using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// Represents a Blog � not a blog post � on a merchant's Shopify store.
    /// </summary>
    public class Blog: ShopifyObject
    {
        /// <summary>
        /// Indicates whether readers can post comments to the blog and if comments are moderated or not. Possible values are:
        /// "no" (default): Readers cannot post comments to blog articles.
        /// "moderate": Readers can post comments to blog articles, but comments must be moderated before they appear.
        /// "yes": Readers can post comments to blog articles without moderation.
        /// </summary>
        [JsonProperty("commentable")]
        public string Commentable { get; set; }

        /// <summary>
        /// The date and time when the blog was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Feedburner is a web feed management provider and can be enabled to provide custom RSS feeds for Shopify bloggers. This property will default to blank or "null" unless feedburner is enabled through the shop admin.
        /// </summary>
        /// <remarks>
        /// Shopify does not document the value type for this property.
        /// </remarks>
        [JsonProperty("feedburner")]
        public object Feedburner { get; set; }

        /// <summary>
        /// URL to the feedburner location for blogs that have enabled feedburner through their store admin.
        /// </summary>
        [JsonProperty("feedburner_url")]
        public string FeedburnerLocation { get; set; }

        /// <summary>
        /// A human-friendly unique string for a blog automatically generated from its title. This handle is used by the Liquid templating language to refer to the blog.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// Tags are additional short descriptors formatted as a string of comma-separated values. For example, if an article has three tags: tag1, tag2, tag3.
        /// </summary>
        /// <remarks>
        /// Shopify seems to ignore these tags when creating or updating a blog.
        /// </remarks>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// States the name of the template a blog is using if it is using an alternate template. If a blog is using the default blog.liquid template, the value returned is "null".
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// The title of the blog.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The date and time when changes were last made to the blog's properties. Note that this is not updated when creating, modifying or deleting articles in the blog.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
