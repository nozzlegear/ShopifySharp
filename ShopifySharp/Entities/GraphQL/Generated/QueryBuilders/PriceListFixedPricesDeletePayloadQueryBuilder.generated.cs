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

public class PriceListFixedPricesDeletePayloadQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesDeletePayload>("priceListFixedPricesDeletePayload")
{
    public PriceListFixedPricesDeletePayloadQueryBuilder AddFieldDeletedFixedPriceVariantIds()
    {
        AddField("deletedFixedPriceVariantIds");
        return this;
    }

    public PriceListFixedPricesDeletePayloadQueryBuilder AddFieldUserErrors(Func<PriceListPriceUserErrorQueryBuilder, PriceListPriceUserErrorQueryBuilder> build)
    {
        AddField<PriceListPriceUserError, PriceListPriceUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}