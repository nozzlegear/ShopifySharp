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
    public sealed class ShopifyPaymentsAccountDisputesArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsDisputeConnection?, ShopifyPaymentsAccountDisputesArgumentsBuilder>
    {
        protected override ShopifyPaymentsAccountDisputesArgumentsBuilder Self => this;

        public ShopifyPaymentsAccountDisputesArgumentsBuilder(IQuery<ShopifyPaymentsDisputeConnection?> query) : base(query)
        {
        }

        public ShopifyPaymentsAccountDisputesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsAccountDisputesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsAccountDisputesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsAccountDisputesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsAccountDisputesArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopifyPaymentsAccountDisputesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}