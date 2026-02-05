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

        public BulkOperationCancelOperationQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}