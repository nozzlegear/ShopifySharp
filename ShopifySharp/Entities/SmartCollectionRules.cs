using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// An entity representing a Shopify Smart Collection Rule.
/// </summary>
public class SmartCollectionRules
{
    /// <summary>
    /// The relationship between the column choice, and the condition.
    /// </summary>
    [JsonProperty("relation")]
    public string Relation { get; set; }

    /// <summary>
    /// Select products for a collection using a condition. Conditions are either strings or numbers, depending on the relation.
    /// </summary>
    [JsonProperty("condition")]
    public string Condition { get; set; }

    /// <summary>
    /// The properties of a product that can be used to to populate a collection.
    /// </summary>
    [JsonProperty("column")]
    public string Column { get; set; }

    /// <summary>
    /// The id of the object that points to additional attributes for the collection rule. This is only required when using metafield definition rules.
    /// </summary>
    [JsonProperty("condition_object_id")]
    public long? ConditionObjectId { get; set; }
}