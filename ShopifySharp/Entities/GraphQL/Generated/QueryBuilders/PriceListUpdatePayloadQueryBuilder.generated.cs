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

public class PriceListUpdatePayloadQueryBuilder() : GraphQueryBuilder<PriceListUpdatePayload>("priceListUpdatePayload")
{
    public PriceListUpdatePayloadQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public PriceListUpdatePayloadQueryBuilder AddFieldUserErrors(Func<PriceListUserErrorQueryBuilder, PriceListUserErrorQueryBuilder> build)
    {
        AddField<PriceListUserError, PriceListUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}