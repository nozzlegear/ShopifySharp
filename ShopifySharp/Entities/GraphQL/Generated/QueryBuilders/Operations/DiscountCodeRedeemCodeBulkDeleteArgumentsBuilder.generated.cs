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
    public sealed class DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeRedeemCodeBulkDeletePayload, DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder>
    {
        protected override DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder Self => this;

        public DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder(IQuery<DiscountCodeRedeemCodeBulkDeletePayload> query) : base(query)
        {
        }

        public DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder DiscountId(string? discountId)
        {
            base.InnerQuery.AddArgument("discountId", discountId);
            return this;
        }

        public DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}