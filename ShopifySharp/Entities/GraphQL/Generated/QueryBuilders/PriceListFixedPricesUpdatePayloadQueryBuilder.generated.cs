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

public class PriceListFixedPricesUpdatePayloadQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesUpdatePayload>("priceListFixedPricesUpdatePayload")
{
    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldDeletedFixedPriceVariantIds()
    {
        AddField("deletedFixedPriceVariantIds");
        return this;
    }

    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldPricesAdded(Func<PriceListPriceQueryBuilder, PriceListPriceQueryBuilder> build)
    {
        AddField<PriceListPrice, PriceListPriceQueryBuilder>("pricesAdded", build);
        return this;
    }

    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldUserErrors(Func<PriceListPriceUserErrorQueryBuilder, PriceListPriceUserErrorQueryBuilder> build)
    {
        AddField<PriceListPriceUserError, PriceListPriceUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}