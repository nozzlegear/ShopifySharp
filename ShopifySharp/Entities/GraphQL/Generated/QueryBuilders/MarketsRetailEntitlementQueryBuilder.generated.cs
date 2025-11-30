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

public class MarketsRetailEntitlementQueryBuilder() : GraphQueryBuilder<MarketsRetailEntitlement>("marketsRetailEntitlement")
{
    public MarketsRetailEntitlementQueryBuilder AddFieldCatalogs(Func<MarketsCatalogsEntitlementQueryBuilder, MarketsCatalogsEntitlementQueryBuilder> build)
    {
        AddField<MarketsCatalogsEntitlement, MarketsCatalogsEntitlementQueryBuilder>("catalogs", build);
        return this;
    }

    public MarketsRetailEntitlementQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}