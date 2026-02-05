#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class BackupRegionUpdateArgumentsBuilder : ArgumentsBuilderBase<BackupRegionUpdatePayload, BackupRegionUpdateArgumentsBuilder>
    {
        protected override BackupRegionUpdateArgumentsBuilder Self => this;

        public BackupRegionUpdateArgumentsBuilder(IQuery<BackupRegionUpdatePayload> query) : base(query)
        {
        }

        public BackupRegionUpdateArgumentsBuilder Region(BackupRegionUpdateInput? region)
        {
            base.InnerQuery.AddArgument("region", region);
            return this;
        }
    }
}