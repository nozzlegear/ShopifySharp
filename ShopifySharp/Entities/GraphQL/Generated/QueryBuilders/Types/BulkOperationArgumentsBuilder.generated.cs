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
    public sealed class BulkOperationArgumentsBuilder : ArgumentsBuilderBase<BulkOperation, BulkOperationArgumentsBuilder>
    {
        protected override BulkOperationArgumentsBuilder Self => this;

        public BulkOperationArgumentsBuilder(IQuery<BulkOperation> query) : base(query)
        {
        }

        public BulkOperationArgumentsBuilder Type(BulkOperationType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}