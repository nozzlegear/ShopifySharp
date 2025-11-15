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

public class TaxAppConfigurePayloadQueryBuilder() : GraphQueryBuilder<TaxAppConfigurePayload>("query taxAppConfigurePayload")
{
    public TaxAppConfigurePayloadQueryBuilder AddFieldTaxAppConfiguration()
    {
        AddField("taxAppConfiguration");
        return this;
    }

    public TaxAppConfigurePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}