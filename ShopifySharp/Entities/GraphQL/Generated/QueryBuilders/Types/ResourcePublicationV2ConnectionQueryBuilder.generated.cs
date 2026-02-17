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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ResourcePublicationV2ConnectionQueryBuilder : FieldsQueryBuilderBase<ResourcePublicationV2Connection, ResourcePublicationV2ConnectionQueryBuilder>
    {
        protected override ResourcePublicationV2ConnectionQueryBuilder Self => this;

        public ResourcePublicationV2ConnectionQueryBuilder() : this("resourcePublicationV2Connection")
        {
        }

        public ResourcePublicationV2ConnectionQueryBuilder(string name) : base(new Query<ResourcePublicationV2Connection>(name))
        {
        }

        public ResourcePublicationV2ConnectionQueryBuilder(IQuery<ResourcePublicationV2Connection> query) : base(query)
        {
        }

        public ResourcePublicationV2ConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2EdgeQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Edge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2EdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Edge>(query);
            return this;
        }

        public ResourcePublicationV2ConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }

        public ResourcePublicationV2ConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}