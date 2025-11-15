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

public class RestrictedForResourceQueryBuilder() : GraphQueryBuilder<RestrictedForResource>("query restrictedForResource")
{
    public RestrictedForResourceQueryBuilder AddFieldRestricted()
    {
        AddField("restricted");
        return this;
    }

    public RestrictedForResourceQueryBuilder AddFieldRestrictedReason()
    {
        AddField("restrictedReason");
        return this;
    }
}