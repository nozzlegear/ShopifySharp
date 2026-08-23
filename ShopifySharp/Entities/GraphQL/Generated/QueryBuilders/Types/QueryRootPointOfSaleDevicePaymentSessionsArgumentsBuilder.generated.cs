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
    public sealed class QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder : ArgumentsBuilderBase<PointOfSaleDevicePaymentSessionConnection?, QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder>
    {
        protected override QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder Self => this;

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder(IQuery<PointOfSaleDevicePaymentSessionConnection?> query) : base(query)
        {
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder SortKey(PointOfSaleDevicePaymentSessionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}