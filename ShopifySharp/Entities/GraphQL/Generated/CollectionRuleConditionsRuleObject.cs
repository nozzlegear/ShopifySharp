#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Specifies object with additional rule attributes.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CollectionRuleConditionsRuleObject>))]
public record CollectionRuleConditionsRuleObject : GraphQLObject<CollectionRuleConditionsRuleObject>, IGraphQLUnionType
{
    public CollectionRuleMetafieldCondition? AsCollectionRuleMetafieldCondition() => this is CollectionRuleConditionsRuleObjectCollectionRuleMetafieldCondition wrapper ? wrapper.Value : null;
}