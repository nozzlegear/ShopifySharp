#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesByProductBulkUpdateUserError>("query priceListFixedPricesByProductBulkUpdateUserError")
{
    public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}