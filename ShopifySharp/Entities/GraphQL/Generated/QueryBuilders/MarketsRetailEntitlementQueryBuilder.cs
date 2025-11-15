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

public class MarketsRetailEntitlementQueryBuilder() : GraphQueryBuilder<MarketsRetailEntitlement>("query marketsRetailEntitlement")
{
    public MarketsRetailEntitlementQueryBuilder AddFieldCatalogs()
    {
        AddField("catalogs");
        return this;
    }

    public MarketsRetailEntitlementQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}