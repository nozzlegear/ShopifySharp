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
    public sealed class DraftOrderBulkRemoveTagsArgumentsBuilder : ArgumentsBuilderBase<DraftOrderBulkRemoveTagsPayload, DraftOrderBulkRemoveTagsArgumentsBuilder>
    {
        protected override DraftOrderBulkRemoveTagsArgumentsBuilder Self => this;

        public DraftOrderBulkRemoveTagsArgumentsBuilder(IQuery<DraftOrderBulkRemoveTagsPayload> query) : base(query)
        {
        }

        public DraftOrderBulkRemoveTagsArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DraftOrderBulkRemoveTagsArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DraftOrderBulkRemoveTagsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public DraftOrderBulkRemoveTagsArgumentsBuilder Tags(ICollection<string>? tags)
        {
            base.InnerQuery.AddArgument("tags", tags);
            return this;
        }
    }
}