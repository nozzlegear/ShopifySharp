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

public class MarketsB2BEntitlementQueryBuilder() : GraphQueryBuilder<MarketsB2BEntitlement>("marketsB2BEntitlement")
{
    public MarketsB2BEntitlementQueryBuilder AddFieldCatalogs(Func<MarketsCatalogsEntitlementQueryBuilder, MarketsCatalogsEntitlementQueryBuilder> build)
    {
        AddField<MarketsCatalogsEntitlement, MarketsCatalogsEntitlementQueryBuilder>("catalogs", build);
        return this;
    }

    public MarketsB2BEntitlementQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}