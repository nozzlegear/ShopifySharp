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
    public sealed class MetaobjectDefinitionConnectionQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionConnection, MetaobjectDefinitionConnectionQueryBuilder>
    {
        protected override MetaobjectDefinitionConnectionQueryBuilder Self => this;

        public MetaobjectDefinitionConnectionQueryBuilder() : this("metaobjectDefinitionConnection")
        {
        }

        public MetaobjectDefinitionConnectionQueryBuilder(string name) : base(new Query<MetaobjectDefinitionConnection>(name))
        {
        }

        public MetaobjectDefinitionConnectionQueryBuilder(IQuery<MetaobjectDefinitionConnection> query) : base(query)
        {
        }

        public MetaobjectDefinitionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinitionEdge>(query);
            return this;
        }

        public MetaobjectDefinitionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public MetaobjectDefinitionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}