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
    public sealed class DraftOrderBulkDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderBulkDeletePayload, DraftOrderBulkDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderBulkDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderBulkDeleteArgumentsBuilder Arguments { get; }
        protected override DraftOrderBulkDeleteOperationQueryBuilder Self => this;

        public DraftOrderBulkDeleteOperationQueryBuilder() : this("draftOrderBulkDelete")
        {
        }

        public DraftOrderBulkDeleteOperationQueryBuilder(string name) : base(new Query<DraftOrderBulkDeletePayload>(name))
        {
            Arguments = new DraftOrderBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderBulkDeleteOperationQueryBuilder(IQuery<DraftOrderBulkDeletePayload> query) : base(query)
        {
            Arguments = new DraftOrderBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderBulkDeleteOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DraftOrderBulkDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}