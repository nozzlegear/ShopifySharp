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
    public sealed class DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryCarrierCalculatedRateGroupConnection, DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder>
    {
        protected override DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder Self => this;

        public DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder(IQuery<DeliveryCarrierCalculatedRateGroupConnection> query) : base(query)
        {
        }

        public DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}