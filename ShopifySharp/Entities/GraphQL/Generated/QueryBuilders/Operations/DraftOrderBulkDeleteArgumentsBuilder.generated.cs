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
    public sealed class DraftOrderBulkDeleteArgumentsBuilder : ArgumentsBuilderBase<DraftOrderBulkDeletePayload, DraftOrderBulkDeleteArgumentsBuilder>
    {
        protected override DraftOrderBulkDeleteArgumentsBuilder Self => this;

        public DraftOrderBulkDeleteArgumentsBuilder(IQuery<DraftOrderBulkDeletePayload> query) : base(query)
        {
        }

        public DraftOrderBulkDeleteArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DraftOrderBulkDeleteArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DraftOrderBulkDeleteArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}