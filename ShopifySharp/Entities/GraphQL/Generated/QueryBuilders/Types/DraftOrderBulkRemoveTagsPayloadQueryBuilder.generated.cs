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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DraftOrderBulkRemoveTagsPayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderBulkRemoveTagsPayload, DraftOrderBulkRemoveTagsPayloadQueryBuilder>
    {
        protected override DraftOrderBulkRemoveTagsPayloadQueryBuilder Self => this;

        public DraftOrderBulkRemoveTagsPayloadQueryBuilder() : this("draftOrderBulkRemoveTagsPayload")
        {
        }

        public DraftOrderBulkRemoveTagsPayloadQueryBuilder(string name) : base(new Query<DraftOrderBulkRemoveTagsPayload>(name))
        {
        }

        public DraftOrderBulkRemoveTagsPayloadQueryBuilder(IQuery<DraftOrderBulkRemoveTagsPayload> query) : base(query)
        {
        }

        public DraftOrderBulkRemoveTagsPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DraftOrderBulkRemoveTagsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}