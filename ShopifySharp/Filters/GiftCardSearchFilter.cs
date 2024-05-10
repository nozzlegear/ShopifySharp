using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters;

public class GiftCardSearchFilter : ListFilter<GiftCard>
{
    /// <summary>
    /// The field and direction to order results by.
    /// Default: `disabled_at DESC`
    /// </summary>
    [JsonProperty("order")]
    public string Order { get; set; }
        
    /// <summary>
    /// The text to search for.
    /// </summary>
    [JsonProperty("query")]
    public string Query { get; set; }

    /// <summary>
    /// Restricts results to those created after date (format: 2008-12-31 03:00).
    /// </summary>
    [JsonProperty("created_at_min")]
    public DateTimeOffset? CreatedAtMin { get; set; }

    /// <summary>
    /// Restricts results to those created before date (format: 2008-12-31 03:00).
    /// </summary>
    [JsonProperty("created_at_max")]
    public DateTimeOffset? CreatedAtMax { get; set; }

    /// <summary>
    /// Restricts results to those last updated after date (format: 2008-12-31 03:00).
    /// </summary>
    [JsonProperty("updated_at_min")]
    public DateTimeOffset? UpdatedAtMin { get; set; }

    /// <summary>
    /// Restricts results to those last updated before date (format: 2008-12-31 03:00).
    /// </summary>
    [JsonProperty("updated_at_max")]
    public DateTimeOffset? UpdatedAtMax { get; set; }
}