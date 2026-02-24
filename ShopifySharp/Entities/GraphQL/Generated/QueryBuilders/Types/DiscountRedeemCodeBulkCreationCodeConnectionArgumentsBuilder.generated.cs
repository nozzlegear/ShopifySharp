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
    public sealed class DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder : ArgumentsBuilderBase<DiscountRedeemCodeBulkCreationCodeConnection, DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder>
    {
        protected override DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder Self => this;

        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder(IQuery<DiscountRedeemCodeBulkCreationCodeConnection> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}