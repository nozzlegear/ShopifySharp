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

public class ConsentPolicyRegionQueryBuilder() : GraphQueryBuilder<ConsentPolicyRegion>("consentPolicyRegion")
{
    public ConsentPolicyRegionQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public ConsentPolicyRegionQueryBuilder AddFieldRegionCode()
    {
        AddField("regionCode");
        return this;
    }
}