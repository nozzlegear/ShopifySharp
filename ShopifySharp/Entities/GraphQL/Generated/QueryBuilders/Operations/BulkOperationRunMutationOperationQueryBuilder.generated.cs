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

        public BulkOperationRunMutationOperationQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationRunMutationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkMutationUserErrorQueryBuilder> build)
        {
            var query = new Query<BulkMutationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkMutationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkMutationUserError>(query);
            return this;
        }
    }
}