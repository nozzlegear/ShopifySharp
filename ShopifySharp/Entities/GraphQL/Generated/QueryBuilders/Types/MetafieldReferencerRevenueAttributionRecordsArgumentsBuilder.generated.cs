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
    public sealed class MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder : ArgumentsBuilderBase<AppRevenueAttributionRecordConnection?, MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder>
    {
        protected override MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder Self => this;

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder(IQuery<AppRevenueAttributionRecordConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder SortKey(AppRevenueAttributionRecordSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}