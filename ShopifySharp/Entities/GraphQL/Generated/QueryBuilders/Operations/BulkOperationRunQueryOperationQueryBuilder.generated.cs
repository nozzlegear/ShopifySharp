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

        public BulkOperationRunQueryOperationQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationRunQueryOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationUserErrorQueryBuilder> build)
        {
            var query = new Query<BulkOperationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperationUserError>(query);
            return this;
        }
    }
}