using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify product.
    /// </summary>
    public class Product : ShopifyObject
    {
        /// <summary>
        /// The name of the product. In a shop's catalog, clicking on a product's title takes you to that product's page.
        /// On a product's page, the product's title typically appears in a large font.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the product, complete with HTML formatting.
        /// </summary>
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }

        /// <summary>
        /// The date and time when the product was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the product was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time when the product was published. The API returns this value in ISO 8601 format. 
        /// Set to NULL to unpublish a product
        /// </summary>
        [JsonProperty("published_at", DefaultValueHandling = DefaultValueHandling.Include, NullValueHandling = NullValueHandling.Include)]
        public DateTimeOffset? PublishedAt { get; set; }

        /// <summary>
        /// The name of the vendor of the product.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// A categorization that a product can be tagged with, commonly used for filtering and searching.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// A human-friendly unique string for the Product automatically generated from its title.
        /// They are used by the Liquid templating language to refer to objects.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// The suffix of the liquid template being used.
        /// By default, the original template is called product.liquid, without any suffix.
        /// Any additional templates will be: product.suffix.liquid.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// The sales channels in which the product is visible.
        /// </summary>
        [JsonProperty("published_scope")]
        public string PublishedScope { get; set; }

        /// <summary>
        /// A categorization that a product can be tagged with, commonly used for filtering and searching.
        /// Each comma-separated tag has a character limit of 255.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// The status of the product
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A list of variant objects, each one representing a slightly different version of the product.
        /// For example, if a product comes in different sizes and colors, each size and color permutation (such as "small black", "medium black", "large blue"), would be a variant.
        /// To reorder variants, update the product with the variants in the desired order.The position attribute on the variant will be ignored.
        /// </summary>
        [JsonProperty("variants")]
        public IEnumerable<ProductVariant> Variants { get; set; }

        /// <summary>
        /// Custom product property names like "Size", "Color", and "Material".
        /// Products are based on permutations of these options. 
        /// A product may have a maximum of 3 options. 255 characters limit each.
        /// </summary>
        [JsonProperty("options")]
        public IEnumerable<ProductOption> Options { get; set; }

        /// <summary>
        /// A list of image objects, each one representing an image associated with the product.
        /// </summary>
        [JsonProperty("images")]
        public IEnumerable<ProductImage> Images { get; set; }

        /// <summary>
        /// Additional metadata about the <see cref="Product"/>. Note: This is not naturally returned with a <see cref="Product"/> response, as
        /// Shopify will not return <see cref="Product"/> metafields unless specified. Instead, you need to query metafields with <see cref="MetaFieldService"/>. 
        /// Uses include: Creating, updating, & deserializing webhook bodies that include them.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<MetaField> Metafields { get; set; }
    }
}
