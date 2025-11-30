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

public class PriceListFixedPricesByProductUpdatePayloadQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesByProductUpdatePayload>("priceListFixedPricesByProductUpdatePayload")
{
    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldPricesToAddProducts(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("pricesToAddProducts", build);
        return this;
    }

    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldPricesToDeleteProducts(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("pricesToDeleteProducts", build);
        return this;
    }

    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldUserErrors(Func<PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder, PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder> build)
    {
        AddField<PriceListFixedPricesByProductBulkUpdateUserError, PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}