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

public class MarketsRegionsEntitlementQueryBuilder() : GraphQueryBuilder<MarketsRegionsEntitlement>("query marketsRegionsEntitlement")
{
    public MarketsRegionsEntitlementQueryBuilder AddFieldCatalogs()
    {
        AddField("catalogs");
        return this;
    }

    public MarketsRegionsEntitlementQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}