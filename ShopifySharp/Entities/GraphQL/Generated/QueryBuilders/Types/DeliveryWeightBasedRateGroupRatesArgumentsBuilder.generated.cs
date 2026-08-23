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
    public sealed class DeliveryWeightBasedRateGroupRatesArgumentsBuilder : ArgumentsBuilderBase<DeliveryWeightBasedRateConnection?, DeliveryWeightBasedRateGroupRatesArgumentsBuilder>
    {
        protected override DeliveryWeightBasedRateGroupRatesArgumentsBuilder Self => this;

        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder(IQuery<DeliveryWeightBasedRateConnection?> query) : base(query)
        {
        }

        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}