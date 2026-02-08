#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CurrentBulkOperationArgumentsBuilder : ArgumentsBuilderBase<BulkOperation, CurrentBulkOperationArgumentsBuilder>
    {
        protected override CurrentBulkOperationArgumentsBuilder Self => this;

        public CurrentBulkOperationArgumentsBuilder(IQuery<BulkOperation> query) : base(query)
        {
        }

        public CurrentBulkOperationArgumentsBuilder Type(BulkOperationType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}