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
    public sealed class DeliveryFlatRateGroupConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryFlatRateGroupConnection, DeliveryFlatRateGroupConnectionArgumentsBuilder>
    {
        protected override DeliveryFlatRateGroupConnectionArgumentsBuilder Self => this;

        public DeliveryFlatRateGroupConnectionArgumentsBuilder(IQuery<DeliveryFlatRateGroupConnection> query) : base(query)
        {
        }

        public DeliveryFlatRateGroupConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryFlatRateGroupConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryFlatRateGroupConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryFlatRateGroupConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryFlatRateGroupConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}