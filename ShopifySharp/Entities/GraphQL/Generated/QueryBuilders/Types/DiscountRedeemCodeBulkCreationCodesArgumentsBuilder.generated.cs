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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DiscountRedeemCodeBulkCreationCodesArgumentsBuilder : ArgumentsBuilderBase<DiscountRedeemCodeBulkCreationCodeConnection?, DiscountRedeemCodeBulkCreationCodesArgumentsBuilder>
    {
        protected override DiscountRedeemCodeBulkCreationCodesArgumentsBuilder Self => this;

        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder(IQuery<DiscountRedeemCodeBulkCreationCodeConnection?> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}