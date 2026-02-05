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
    public sealed class BulkOperationRunQueryOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperationRunQueryPayload, BulkOperationRunQueryOperationQueryBuilder>, IGraphOperationQueryBuilder<BulkOperationRunQueryPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BulkOperationRunQueryArgumentsBuilder Arguments { get; }
        protected override BulkOperationRunQueryOperationQueryBuilder Self => this;

        public BulkOperationRunQueryOperationQueryBuilder() : this("bulkOperationRunQuery")
        {
        }

        public BulkOperationRunQueryOperationQueryBuilder(string name) : base(new Query<BulkOperationRunQueryPayload>(name))
        {
            Arguments = new BulkOperationRunQueryArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationRunQueryOperationQueryBuilder(IQuery<BulkOperationRunQueryPayload> query) : base(query)
        {
            Arguments = new BulkOperationRunQueryArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationRunQueryOperationQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationRunQueryOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationUserErrorQueryBuilder> build)
        {
            var query = new Query<BulkOperationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperationUserError>(query);
            return this;
        }
    }
}