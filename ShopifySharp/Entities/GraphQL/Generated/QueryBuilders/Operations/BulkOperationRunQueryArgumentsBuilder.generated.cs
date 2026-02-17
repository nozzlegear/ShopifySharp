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
    public sealed class BulkOperationRunQueryArgumentsBuilder : ArgumentsBuilderBase<BulkOperationRunQueryPayload, BulkOperationRunQueryArgumentsBuilder>
    {
        protected override BulkOperationRunQueryArgumentsBuilder Self => this;

        public BulkOperationRunQueryArgumentsBuilder(IQuery<BulkOperationRunQueryPayload> query) : base(query)
        {
        }

        public BulkOperationRunQueryArgumentsBuilder GroupObjects(bool? groupObjects)
        {
            base.InnerQuery.AddArgument("groupObjects", groupObjects);
            return this;
        }

        public BulkOperationRunQueryArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}