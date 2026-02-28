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
    public sealed class BulkOperationsArgumentsBuilder : ArgumentsBuilderBase<BulkOperationConnection, BulkOperationsArgumentsBuilder>
    {
        protected override BulkOperationsArgumentsBuilder Self => this;

        public BulkOperationsArgumentsBuilder(IQuery<BulkOperationConnection> query) : base(query)
        {
        }

        public BulkOperationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public BulkOperationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public BulkOperationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public BulkOperationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public BulkOperationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public BulkOperationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public BulkOperationsArgumentsBuilder SortKey(BulkOperationsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}