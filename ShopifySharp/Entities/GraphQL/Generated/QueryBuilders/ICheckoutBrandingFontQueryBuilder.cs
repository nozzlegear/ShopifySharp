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

public class ICheckoutBrandingFontQueryBuilder() : GraphQueryBuilder<ICheckoutBrandingFont>("query iCheckoutBrandingFont")
{
    public ICheckoutBrandingFontQueryBuilder AddFieldSources()
    {
        AddField("sources");
        return this;
    }

    public ICheckoutBrandingFontQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}