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
    public sealed class DiscountRedeemCodeBulkAddArgumentsBuilder : ArgumentsBuilderBase<DiscountRedeemCodeBulkAddPayload, DiscountRedeemCodeBulkAddArgumentsBuilder>
    {
        protected override DiscountRedeemCodeBulkAddArgumentsBuilder Self => this;

        public DiscountRedeemCodeBulkAddArgumentsBuilder(IQuery<DiscountRedeemCodeBulkAddPayload> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkAddArgumentsBuilder Codes(ICollection<DiscountRedeemCodeInput>? codes)
        {
            base.InnerQuery.AddArgument("codes", codes);
            return this;
        }

        public DiscountRedeemCodeBulkAddArgumentsBuilder DiscountId(string? discountId)
        {
            base.InnerQuery.AddArgument("discountId", discountId);
            return this;
        }
    }
}