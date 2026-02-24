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
    public sealed class DeliveryProfileConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfileConnection, DeliveryProfileConnectionArgumentsBuilder>
    {
        protected override DeliveryProfileConnectionArgumentsBuilder Self => this;

        public DeliveryProfileConnectionArgumentsBuilder(IQuery<DeliveryProfileConnection> query) : base(query)
        {
        }

        public DeliveryProfileConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryProfileConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryProfileConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryProfileConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryProfileConnectionArgumentsBuilder MerchantOwnedOnly(bool? merchantOwnedOnly)
        {
            base.InnerQuery.AddArgument("merchantOwnedOnly", merchantOwnedOnly);
            return this;
        }

        public DeliveryProfileConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}