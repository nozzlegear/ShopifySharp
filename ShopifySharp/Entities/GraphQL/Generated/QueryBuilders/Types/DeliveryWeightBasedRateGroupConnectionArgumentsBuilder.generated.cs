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
    public sealed class DeliveryWeightBasedRateGroupConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryWeightBasedRateGroupConnection, DeliveryWeightBasedRateGroupConnectionArgumentsBuilder>
    {
        protected override DeliveryWeightBasedRateGroupConnectionArgumentsBuilder Self => this;

        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder(IQuery<DeliveryWeightBasedRateGroupConnection> query) : base(query)
        {
        }

        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}