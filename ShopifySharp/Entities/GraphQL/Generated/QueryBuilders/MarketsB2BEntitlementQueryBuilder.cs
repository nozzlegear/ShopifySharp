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

public class MarketsB2BEntitlementQueryBuilder() : GraphQueryBuilder<MarketsB2BEntitlement>("query marketsB2BEntitlement")
{
    public MarketsB2BEntitlementQueryBuilder AddFieldCatalogs()
    {
        AddField("catalogs");
        return this;
    }

    public MarketsB2BEntitlementQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}