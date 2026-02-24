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
    public sealed class QueryRootCurrentBulkOperationArgumentsBuilder : ArgumentsBuilderBase<BulkOperation?, QueryRootCurrentBulkOperationArgumentsBuilder>
    {
        protected override QueryRootCurrentBulkOperationArgumentsBuilder Self => this;

        public QueryRootCurrentBulkOperationArgumentsBuilder(IQuery<BulkOperation?> query) : base(query)
        {
        }

        public QueryRootCurrentBulkOperationArgumentsBuilder Type(BulkOperationType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}