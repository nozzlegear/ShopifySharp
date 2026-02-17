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
    public sealed class DiscountCodeBulkActivateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBulkActivatePayload, DiscountCodeBulkActivateArgumentsBuilder>
    {
        protected override DiscountCodeBulkActivateArgumentsBuilder Self => this;

        public DiscountCodeBulkActivateArgumentsBuilder(IQuery<DiscountCodeBulkActivatePayload> query) : base(query)
        {
        }

        public DiscountCodeBulkActivateArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DiscountCodeBulkActivateArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DiscountCodeBulkActivateArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}