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
    public sealed class DiscountAutomaticBulkDeleteArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticBulkDeletePayload, DiscountAutomaticBulkDeleteArgumentsBuilder>
    {
        protected override DiscountAutomaticBulkDeleteArgumentsBuilder Self => this;

        public DiscountAutomaticBulkDeleteArgumentsBuilder(IQuery<DiscountAutomaticBulkDeletePayload> query) : base(query)
        {
        }

        public DiscountAutomaticBulkDeleteArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DiscountAutomaticBulkDeleteArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DiscountAutomaticBulkDeleteArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}