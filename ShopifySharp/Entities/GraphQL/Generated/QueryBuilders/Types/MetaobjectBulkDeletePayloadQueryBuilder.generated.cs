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
    public sealed class MetaobjectBulkDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MetaobjectBulkDeletePayload, MetaobjectBulkDeletePayloadQueryBuilder>
    {
        protected override MetaobjectBulkDeletePayloadQueryBuilder Self => this;

        public MetaobjectBulkDeletePayloadQueryBuilder() : this("metaobjectBulkDeletePayload")
        {
        }

        public MetaobjectBulkDeletePayloadQueryBuilder(string name) : base(new Query<MetaobjectBulkDeletePayload>(name))
        {
        }

        public MetaobjectBulkDeletePayloadQueryBuilder(IQuery<MetaobjectBulkDeletePayload> query) : base(query)
        {
        }

        public MetaobjectBulkDeletePayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public MetaobjectBulkDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}