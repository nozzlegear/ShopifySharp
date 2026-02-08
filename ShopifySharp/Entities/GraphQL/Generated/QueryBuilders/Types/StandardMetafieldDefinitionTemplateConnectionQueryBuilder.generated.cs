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
    public sealed class StandardMetafieldDefinitionTemplateConnectionQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionTemplateConnection, StandardMetafieldDefinitionTemplateConnectionQueryBuilder>
    {
        protected override StandardMetafieldDefinitionTemplateConnectionQueryBuilder Self => this;

        public StandardMetafieldDefinitionTemplateConnectionQueryBuilder() : this("standardMetafieldDefinitionTemplateConnection")
        {
        }

        public StandardMetafieldDefinitionTemplateConnectionQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionTemplateConnection>(name))
        {
        }

        public StandardMetafieldDefinitionTemplateConnectionQueryBuilder(IQuery<StandardMetafieldDefinitionTemplateConnection> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionTemplateConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateEdgeQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplateEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplateEdge>(query);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplate>(query);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}