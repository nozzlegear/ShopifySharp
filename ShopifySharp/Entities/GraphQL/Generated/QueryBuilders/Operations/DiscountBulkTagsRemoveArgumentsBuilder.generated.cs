#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountBulkTagsRemoveArgumentsBuilder : ArgumentsBuilderBase<DiscountBulkTagsRemovePayload, DiscountBulkTagsRemoveArgumentsBuilder>
    {
        protected override DiscountBulkTagsRemoveArgumentsBuilder Self => this;

        public DiscountBulkTagsRemoveArgumentsBuilder(IQuery<DiscountBulkTagsRemovePayload> query) : base(query)
        {
        }

        public DiscountBulkTagsRemoveArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DiscountBulkTagsRemoveArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DiscountBulkTagsRemoveArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public DiscountBulkTagsRemoveArgumentsBuilder Tags(ICollection<string>? tags)
        {
            base.InnerQuery.AddArgument("tags", tags);
            return this;
        }
    }
}