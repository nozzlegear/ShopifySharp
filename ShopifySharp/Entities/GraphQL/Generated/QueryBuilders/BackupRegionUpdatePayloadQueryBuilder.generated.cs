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

public class BackupRegionUpdatePayloadQueryBuilder() : GraphQueryBuilder<BackupRegionUpdatePayload>("backupRegionUpdatePayload")
{
    public BackupRegionUpdatePayloadQueryBuilder AddFieldBackupRegion(Func<MarketRegionQueryBuilder, MarketRegionQueryBuilder> build)
    {
        AddField<IMarketRegion, MarketRegionQueryBuilder>("backupRegion", build);
        return this;
    }

    public BackupRegionUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MarketUserErrorQueryBuilder, MarketUserErrorQueryBuilder> build)
    {
        AddField<MarketUserError, MarketUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}