using Newtonsoft.Json;

namespace ShopifySharp;

public class ShopifyObjectGid
{
    //The GraphQL ID of the object
    [JsonProperty("admin_graphql_api_id")]
    public string AdminGraphQLAPIId { get; set; }
}