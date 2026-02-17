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
    public sealed class DraftOrderBulkAddTagsOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderBulkAddTagsPayload, DraftOrderBulkAddTagsOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderBulkAddTagsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderBulkAddTagsArgumentsBuilder Arguments { get; }
        protected override DraftOrderBulkAddTagsOperationQueryBuilder Self => this;

        public DraftOrderBulkAddTagsOperationQueryBuilder() : this("draftOrderBulkAddTags")
        {
        }

        public DraftOrderBulkAddTagsOperationQueryBuilder(string name) : base(new Query<DraftOrderBulkAddTagsPayload>(name))
        {
            Arguments = new DraftOrderBulkAddTagsArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderBulkAddTagsOperationQueryBuilder(IQuery<DraftOrderBulkAddTagsPayload> query) : base(query)
        {
            Arguments = new DraftOrderBulkAddTagsArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderBulkAddTagsOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DraftOrderBulkAddTagsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}