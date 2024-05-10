using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters;

public class ProductCountFilter : Parameterizable
{
    /// <summary>
    /// Restrict results to after the specified ID. 
    /// </summary>
    [JsonProperty("since_id")]
    public long? SinceId { get; set; }

    /// <summary>
    /// Filter by product type.
    /// </summary>
    [JsonProperty("product_type")]
    public string ProductType { get; set; }

    /// <summary>
    /// Filter by collection id.
    /// </summary>
    [JsonProperty("collection_id")]
    public long? CollectionId { get; set; }
        
    /// <summary>
    /// Filter by product vendor.
    /// </summary>
    [JsonProperty("vendor")]
    public string Vendor { get; set; }
        
    /// <summary>
    /// Restrict results to those created at or after date.
    /// </summary>
    [JsonProperty("created_at_max")]
    public DateTimeOffset? CreatedAtMax { get; set; }
        
    /// <summary>
    /// Restrict results to those created at or before date.
    /// </summary>
    [JsonProperty("updated_at_min")]
    public DateTimeOffset? UpdatedAtMin { get; set; }

    /// <summary>
    /// Restrict results to those last updated at or before date.
    /// </summary>
    [JsonProperty("updated_at_max")]
    public DateTimeOffset? UpdatedAtMax { get; set; }
        
    /// <summary>
    /// Restricts results to those published after date.
    /// </summary>
    [JsonProperty("published_at_min")]
    public DateTimeOffset? PublishedAtMin { get; set; }

    /// <summary>
    /// Restricts results to those published before date.
    /// </summary>
    [JsonProperty("published_at_max")]
    public DateTimeOffset? PublishedAtMax { get; set; }

    /// <summary>
    /// Restricts results to those with the given published status. Known values: published, unpublished, any. Default: any.
    /// </summary>
    [JsonProperty("published_status")]
    public string PublishedStatus { get; set; }
}