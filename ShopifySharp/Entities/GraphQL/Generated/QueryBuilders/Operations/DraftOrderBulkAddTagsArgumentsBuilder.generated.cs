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
    public sealed class DraftOrderBulkAddTagsArgumentsBuilder : ArgumentsBuilderBase<DraftOrderBulkAddTagsPayload, DraftOrderBulkAddTagsArgumentsBuilder>
    {
        protected override DraftOrderBulkAddTagsArgumentsBuilder Self => this;

        public DraftOrderBulkAddTagsArgumentsBuilder(IQuery<DraftOrderBulkAddTagsPayload> query) : base(query)
        {
        }

        public DraftOrderBulkAddTagsArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DraftOrderBulkAddTagsArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DraftOrderBulkAddTagsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public DraftOrderBulkAddTagsArgumentsBuilder Tags(ICollection<string>? tags)
        {
            base.InnerQuery.AddArgument("tags", tags);
            return this;
        }
    }
}