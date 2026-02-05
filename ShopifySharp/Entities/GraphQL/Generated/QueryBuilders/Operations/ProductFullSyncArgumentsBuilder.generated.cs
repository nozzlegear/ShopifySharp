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
    public sealed class ProductFullSyncArgumentsBuilder : ArgumentsBuilderBase<ProductFullSyncPayload, ProductFullSyncArgumentsBuilder>
    {
        protected override ProductFullSyncArgumentsBuilder Self => this;

        public ProductFullSyncArgumentsBuilder(IQuery<ProductFullSyncPayload> query) : base(query)
        {
        }

        public ProductFullSyncArgumentsBuilder BeforeUpdatedAt(DateTimeOffset? beforeUpdatedAt)
        {
            base.InnerQuery.AddArgument("beforeUpdatedAt", beforeUpdatedAt);
            return this;
        }

        public ProductFullSyncArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ProductFullSyncArgumentsBuilder UpdatedAtSince(DateTimeOffset? updatedAtSince)
        {
            base.InnerQuery.AddArgument("updatedAtSince", updatedAtSince);
            return this;
        }
    }
}