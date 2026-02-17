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
    public sealed class DiscountCodeBulkDeactivateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBulkDeactivatePayload, DiscountCodeBulkDeactivateArgumentsBuilder>
    {
        protected override DiscountCodeBulkDeactivateArgumentsBuilder Self => this;

        public DiscountCodeBulkDeactivateArgumentsBuilder(IQuery<DiscountCodeBulkDeactivatePayload> query) : base(query)
        {
        }

        public DiscountCodeBulkDeactivateArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DiscountCodeBulkDeactivateArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DiscountCodeBulkDeactivateArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}