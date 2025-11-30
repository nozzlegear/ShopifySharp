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

public class MarketsTypeQueryBuilder() : GraphQueryBuilder<MarketsType>("marketsType")
{
    public MarketsTypeQueryBuilder AddFieldB2b(Func<MarketsB2BEntitlementQueryBuilder, MarketsB2BEntitlementQueryBuilder> build)
    {
        AddField<MarketsB2BEntitlement, MarketsB2BEntitlementQueryBuilder>("b2b", build);
        return this;
    }

    public MarketsTypeQueryBuilder AddFieldRegions(Func<MarketsRegionsEntitlementQueryBuilder, MarketsRegionsEntitlementQueryBuilder> build)
    {
        AddField<MarketsRegionsEntitlement, MarketsRegionsEntitlementQueryBuilder>("regions", build);
        return this;
    }

    public MarketsTypeQueryBuilder AddFieldRetail(Func<MarketsRetailEntitlementQueryBuilder, MarketsRetailEntitlementQueryBuilder> build)
    {
        AddField<MarketsRetailEntitlement, MarketsRetailEntitlementQueryBuilder>("retail", build);
        return this;
    }

    public MarketsTypeQueryBuilder AddFieldThemes(Func<MarketsThemesEntitlementQueryBuilder, MarketsThemesEntitlementQueryBuilder> build)
    {
        AddField<MarketsThemesEntitlement, MarketsThemesEntitlementQueryBuilder>("themes", build);
        return this;
    }
}