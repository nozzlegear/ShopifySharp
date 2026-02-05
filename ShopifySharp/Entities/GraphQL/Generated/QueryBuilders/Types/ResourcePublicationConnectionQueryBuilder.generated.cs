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
    public sealed class ResourcePublicationConnectionQueryBuilder : FieldsQueryBuilderBase<ResourcePublicationConnection, ResourcePublicationConnectionQueryBuilder>
    {
        protected override ResourcePublicationConnectionQueryBuilder Self => this;

        public ResourcePublicationConnectionQueryBuilder() : this("resourcePublicationConnection")
        {
        }

        public ResourcePublicationConnectionQueryBuilder(string name) : base(new Query<ResourcePublicationConnection>(name))
        {
        }

        public ResourcePublicationConnectionQueryBuilder(IQuery<ResourcePublicationConnection> query) : base(query)
        {
        }

        public ResourcePublicationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationEdgeQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationEdge>(query);
            return this;
        }

        public ResourcePublicationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationQueryBuilder> build)
        {
            var query = new Query<ResourcePublication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublication>(query);
            return this;
        }

        public ResourcePublicationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}