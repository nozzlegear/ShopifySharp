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
    public sealed class BulkOperationRunMutationArgumentsBuilder : ArgumentsBuilderBase<BulkOperationRunMutationPayload, BulkOperationRunMutationArgumentsBuilder>
    {
        protected override BulkOperationRunMutationArgumentsBuilder Self => this;

        public BulkOperationRunMutationArgumentsBuilder(IQuery<BulkOperationRunMutationPayload> query) : base(query)
        {
        }

        public BulkOperationRunMutationArgumentsBuilder ClientIdentifier(string? clientIdentifier)
        {
            base.InnerQuery.AddArgument("clientIdentifier", clientIdentifier);
            return this;
        }

        public BulkOperationRunMutationArgumentsBuilder Mutation(string? mutation)
        {
            base.InnerQuery.AddArgument("mutation", mutation);
            return this;
        }

        public BulkOperationRunMutationArgumentsBuilder StagedUploadPath(string? stagedUploadPath)
        {
            base.InnerQuery.AddArgument("stagedUploadPath", stagedUploadPath);
            return this;
        }
    }
}