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
    public sealed class QueryRootDeliveryProfilesArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfileConnection?, QueryRootDeliveryProfilesArgumentsBuilder>
    {
        protected override QueryRootDeliveryProfilesArgumentsBuilder Self => this;

        public QueryRootDeliveryProfilesArgumentsBuilder(IQuery<DeliveryProfileConnection?> query) : base(query)
        {
        }

        public QueryRootDeliveryProfilesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootDeliveryProfilesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootDeliveryProfilesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootDeliveryProfilesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootDeliveryProfilesArgumentsBuilder MerchantOwnedOnly(bool? merchantOwnedOnly)
        {
            base.InnerQuery.AddArgument("merchantOwnedOnly", merchantOwnedOnly);
            return this;
        }

        public QueryRootDeliveryProfilesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}