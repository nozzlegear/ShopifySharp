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
    public sealed class MetafieldDefinitionConstraintValueConnectionQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConstraintValueConnection, MetafieldDefinitionConstraintValueConnectionQueryBuilder>
    {
        protected override MetafieldDefinitionConstraintValueConnectionQueryBuilder Self => this;

        public MetafieldDefinitionConstraintValueConnectionQueryBuilder() : this("metafieldDefinitionConstraintValueConnection")
        {
        }

        public MetafieldDefinitionConstraintValueConnectionQueryBuilder(string name) : base(new Query<MetafieldDefinitionConstraintValueConnection>(name))
        {
        }

        public MetafieldDefinitionConstraintValueConnectionQueryBuilder(IQuery<MetafieldDefinitionConstraintValueConnection> query) : base(query)
        {
        }

        public MetafieldDefinitionConstraintValueConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintValueEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraintValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraintValueEdge>(query);
            return this;
        }

        public MetafieldDefinitionConstraintValueConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintValueQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraintValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraintValue>(query);
            return this;
        }

        public MetafieldDefinitionConstraintValueConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}