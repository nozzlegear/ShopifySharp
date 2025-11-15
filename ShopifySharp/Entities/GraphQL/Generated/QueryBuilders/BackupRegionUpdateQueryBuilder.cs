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

public class BackupRegionUpdateQueryBuilder() : GraphQueryBuilder<BackupRegionUpdatePayload>("query backupRegionUpdate")
{
    public BackupRegionUpdateQueryBuilder AddArgumentRegion(BackupRegionUpdateInput? region)
    {
        AddArgument("region", region);
        return this;
    }
}