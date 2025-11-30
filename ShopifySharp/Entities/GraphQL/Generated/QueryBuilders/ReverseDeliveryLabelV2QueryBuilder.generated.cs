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

public class ReverseDeliveryLabelV2QueryBuilder() : GraphQueryBuilder<ReverseDeliveryLabelV2>("reverseDeliveryLabelV2")
{
    public ReverseDeliveryLabelV2QueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ReverseDeliveryLabelV2QueryBuilder AddFieldPublicFileUrl()
    {
        AddField("publicFileUrl");
        return this;
    }

    public ReverseDeliveryLabelV2QueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}