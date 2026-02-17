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
    public sealed class DiscountCodeBulkDeleteArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBulkDeletePayload, DiscountCodeBulkDeleteArgumentsBuilder>
    {
        protected override DiscountCodeBulkDeleteArgumentsBuilder Self => this;

        public DiscountCodeBulkDeleteArgumentsBuilder(IQuery<DiscountCodeBulkDeletePayload> query) : base(query)
        {
        }

        public DiscountCodeBulkDeleteArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DiscountCodeBulkDeleteArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DiscountCodeBulkDeleteArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}