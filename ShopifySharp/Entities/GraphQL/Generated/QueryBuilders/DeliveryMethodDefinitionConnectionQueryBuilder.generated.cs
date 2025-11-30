#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DeliveryMethodDefinitionConnectionQueryBuilder() : GraphQueryBuilder<DeliveryMethodDefinitionConnection>("deliveryMethodDefinitionConnection")
{
    public DeliveryMethodDefinitionConnectionQueryBuilder AddFieldEdges(Func<DeliveryMethodDefinitionEdgeQueryBuilder, DeliveryMethodDefinitionEdgeQueryBuilder> build)
    {
        AddField<DeliveryMethodDefinitionEdge, DeliveryMethodDefinitionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryMethodDefinitionConnectionQueryBuilder AddFieldNodes(Func<DeliveryMethodDefinitionQueryBuilder, DeliveryMethodDefinitionQueryBuilder> build)
    {
        AddField<DeliveryMethodDefinition, DeliveryMethodDefinitionQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryMethodDefinitionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}