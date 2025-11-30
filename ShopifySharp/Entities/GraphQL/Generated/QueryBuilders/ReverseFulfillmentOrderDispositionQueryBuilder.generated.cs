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

public class ReverseFulfillmentOrderDispositionQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderDisposition>("reverseFulfillmentOrderDisposition")
{
    public ReverseFulfillmentOrderDispositionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ReverseFulfillmentOrderDispositionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseFulfillmentOrderDispositionQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public ReverseFulfillmentOrderDispositionQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ReverseFulfillmentOrderDispositionQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}