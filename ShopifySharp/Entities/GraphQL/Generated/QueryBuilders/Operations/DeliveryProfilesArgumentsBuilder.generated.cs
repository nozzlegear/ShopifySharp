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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DeliveryProfilesArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfileConnection, DeliveryProfilesArgumentsBuilder>
    {
        protected override DeliveryProfilesArgumentsBuilder Self => this;

        public DeliveryProfilesArgumentsBuilder(IQuery<DeliveryProfileConnection> query) : base(query)
        {
        }

        public DeliveryProfilesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryProfilesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryProfilesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryProfilesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryProfilesArgumentsBuilder MerchantOwnedOnly(bool? merchantOwnedOnly)
        {
            base.InnerQuery.AddArgument("merchantOwnedOnly", merchantOwnedOnly);
            return this;
        }

        public DeliveryProfilesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}