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
    public sealed class DeliveryValueBasedRateGroupConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryValueBasedRateGroupConnection, DeliveryValueBasedRateGroupConnectionArgumentsBuilder>
    {
        protected override DeliveryValueBasedRateGroupConnectionArgumentsBuilder Self => this;

        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder(IQuery<DeliveryValueBasedRateGroupConnection> query) : base(query)
        {
        }

        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}