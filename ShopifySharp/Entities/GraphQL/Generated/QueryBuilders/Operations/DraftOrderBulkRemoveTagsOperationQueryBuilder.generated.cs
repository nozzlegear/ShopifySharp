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
    public sealed class DraftOrderBulkRemoveTagsOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderBulkRemoveTagsPayload, DraftOrderBulkRemoveTagsOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderBulkRemoveTagsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderBulkRemoveTagsArgumentsBuilder Arguments { get; }
        protected override DraftOrderBulkRemoveTagsOperationQueryBuilder Self => this;

        public DraftOrderBulkRemoveTagsOperationQueryBuilder() : this("draftOrderBulkRemoveTags")
        {
        }

        public DraftOrderBulkRemoveTagsOperationQueryBuilder(string name) : base(new Query<DraftOrderBulkRemoveTagsPayload>(name))
        {
            Arguments = new DraftOrderBulkRemoveTagsArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderBulkRemoveTagsOperationQueryBuilder(IQuery<DraftOrderBulkRemoveTagsPayload> query) : base(query)
        {
            Arguments = new DraftOrderBulkRemoveTagsArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderBulkRemoveTagsOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DraftOrderBulkRemoveTagsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}