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

public class TaxAppConfigureUserErrorQueryBuilder() : GraphQueryBuilder<TaxAppConfigureUserError>("query taxAppConfigureUserError")
{
    public TaxAppConfigureUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public TaxAppConfigureUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public TaxAppConfigureUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}