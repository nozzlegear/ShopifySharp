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
    public sealed class DeliveryValueBasedRateGroupRatesArgumentsBuilder : ArgumentsBuilderBase<DeliveryValueBasedRateConnection?, DeliveryValueBasedRateGroupRatesArgumentsBuilder>
    {
        protected override DeliveryValueBasedRateGroupRatesArgumentsBuilder Self => this;

        public DeliveryValueBasedRateGroupRatesArgumentsBuilder(IQuery<DeliveryValueBasedRateConnection?> query) : base(query)
        {
        }

        public DeliveryValueBasedRateGroupRatesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}