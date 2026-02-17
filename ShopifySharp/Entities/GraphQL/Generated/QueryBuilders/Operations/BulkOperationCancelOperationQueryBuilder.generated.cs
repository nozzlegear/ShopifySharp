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
    public sealed class BulkOperationCancelOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperationCancelPayload, BulkOperationCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<BulkOperationCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BulkOperationCancelArgumentsBuilder Arguments { get; }
        protected override BulkOperationCancelOperationQueryBuilder Self => this;

        public BulkOperationCancelOperationQueryBuilder() : this("bulkOperationCancel")
        {
        }

        public BulkOperationCancelOperationQueryBuilder(string name) : base(new Query<BulkOperationCancelPayload>(name))
        {
            Arguments = new BulkOperationCancelArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationCancelOperationQueryBuilder(IQuery<BulkOperationCancelPayload> query) : base(query)
        {
            Arguments = new BulkOperationCancelArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationCancelOperationQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}