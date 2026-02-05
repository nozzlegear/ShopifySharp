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
    public sealed class BulkOperationRunMutationOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperationRunMutationPayload, BulkOperationRunMutationOperationQueryBuilder>, IGraphOperationQueryBuilder<BulkOperationRunMutationPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BulkOperationRunMutationArgumentsBuilder Arguments { get; }
        protected override BulkOperationRunMutationOperationQueryBuilder Self => this;

        public BulkOperationRunMutationOperationQueryBuilder() : this("bulkOperationRunMutation")
        {
        }

        public BulkOperationRunMutationOperationQueryBuilder(string name) : base(new Query<BulkOperationRunMutationPayload>(name))
        {
            Arguments = new BulkOperationRunMutationArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationRunMutationOperationQueryBuilder(IQuery<BulkOperationRunMutationPayload> query) : base(query)
        {
            Arguments = new BulkOperationRunMutationArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationRunMutationOperationQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationRunMutationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkMutationUserErrorQueryBuilder> build)
        {
            var query = new Query<BulkMutationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkMutationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkMutationUserError>(query);
            return this;
        }
    }
}