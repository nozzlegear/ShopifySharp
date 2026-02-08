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
    public sealed class MetafieldRelationConnectionQueryBuilder : FieldsQueryBuilderBase<MetafieldRelationConnection, MetafieldRelationConnectionQueryBuilder>
    {
        protected override MetafieldRelationConnectionQueryBuilder Self => this;

        public MetafieldRelationConnectionQueryBuilder() : this("metafieldRelationConnection")
        {
        }

        public MetafieldRelationConnectionQueryBuilder(string name) : base(new Query<MetafieldRelationConnection>(name))
        {
        }

        public MetafieldRelationConnectionQueryBuilder(IQuery<MetafieldRelationConnection> query) : base(query)
        {
        }

        public MetafieldRelationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldRelationEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldRelationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldRelationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelationEdge>(query);
            return this;
        }

        public MetafieldRelationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldRelationQueryBuilder> build)
        {
            var query = new Query<MetafieldRelation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldRelationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelation>(query);
            return this;
        }

        public MetafieldRelationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}