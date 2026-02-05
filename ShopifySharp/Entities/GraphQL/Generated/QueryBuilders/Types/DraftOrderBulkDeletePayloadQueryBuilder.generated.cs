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
    public sealed class DraftOrderBulkDeletePayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderBulkDeletePayload, DraftOrderBulkDeletePayloadQueryBuilder>
    {
        protected override DraftOrderBulkDeletePayloadQueryBuilder Self => this;

        public DraftOrderBulkDeletePayloadQueryBuilder() : this("draftOrderBulkDeletePayload")
        {
        }

        public DraftOrderBulkDeletePayloadQueryBuilder(string name) : base(new Query<DraftOrderBulkDeletePayload>(name))
        {
        }

        public DraftOrderBulkDeletePayloadQueryBuilder(IQuery<DraftOrderBulkDeletePayload> query) : base(query)
        {
        }

        public DraftOrderBulkDeletePayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DraftOrderBulkDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}