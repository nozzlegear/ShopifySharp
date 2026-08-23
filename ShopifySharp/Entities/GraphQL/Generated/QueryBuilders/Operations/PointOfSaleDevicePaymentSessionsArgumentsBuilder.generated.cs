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
    public sealed class PointOfSaleDevicePaymentSessionsArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevicePaymentSessionConnection, PointOfSaleDevicePaymentSessionsArgumentsBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionsArgumentsBuilder Self => this;

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder(IQuery<PointOfSaleDevicePaymentSessionConnection> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsArgumentsBuilder SortKey(PointOfSaleDevicePaymentSessionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}