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
    public sealed class DeliveryValueBasedRateConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryValueBasedRateConnection, DeliveryValueBasedRateConnectionArgumentsBuilder>
    {
        protected override DeliveryValueBasedRateConnectionArgumentsBuilder Self => this;

        public DeliveryValueBasedRateConnectionArgumentsBuilder(IQuery<DeliveryValueBasedRateConnection> query) : base(query)
        {
        }

        public DeliveryValueBasedRateConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryValueBasedRateConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryValueBasedRateConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryValueBasedRateConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryValueBasedRateConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}