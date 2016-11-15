using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify blog article.
    /// </summary>
    public class ShopifyArticle : ShopifyObject
    {
        /// <summary>
        /// The name of the author of this article
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// A unique numeric identifier for the blog containing the article.
        /// </summary>
        [JsonProperty("blog_id")]
        public long? BlogId { get; set; }

        /// <summary>
        /// The text of the body of the article, complete with HTML markup.
        /// </summary>
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }

        /// <summary>
        /// The date and time when the article was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// A human-friendly unique string for an article automatically generated from its title. It is used in the article's URL.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// The article image.
        /// </summary>
        [JsonProperty("image")]
        public ShopifyArticleImage Image { get; set; }

        /// <summary>
        /// States whether or not the article is visible. 
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// The date and time when the article was published. 
        /// </summary>
        [JsonProperty("published_at")]
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The text of the summary of the article, complete with HTML markup.
        /// </summary>
        [JsonProperty("summary_html")]
        public string SummaryHtml { get; set; }

        /// <summary>
        /// Tags are additional short descriptors formatted as a string of comma-separated values. For example, if an article has three tags: tag1, tag2, tag3.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// States the name of the template an article is using if it is using an alternate template. If an article is using the default article.liquid template, the value returned is null.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// The title of the article.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The date and time when the article was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A unique numeric identifier for the author of the article.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }
    }
}
