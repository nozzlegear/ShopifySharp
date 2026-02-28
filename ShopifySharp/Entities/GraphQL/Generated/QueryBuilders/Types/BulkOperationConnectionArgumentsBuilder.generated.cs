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
    public sealed class BulkOperationConnectionArgumentsBuilder : ArgumentsBuilderBase<BulkOperationConnection, BulkOperationConnectionArgumentsBuilder>
    {
        protected override BulkOperationConnectionArgumentsBuilder Self => this;

        public BulkOperationConnectionArgumentsBuilder(IQuery<BulkOperationConnection> query) : base(query)
        {
        }

        public BulkOperationConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public BulkOperationConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public BulkOperationConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public BulkOperationConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public BulkOperationConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public BulkOperationConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public BulkOperationConnectionArgumentsBuilder SortKey(BulkOperationsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}