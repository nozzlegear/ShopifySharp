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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class StandardMetafieldDefinitionTemplatesOperationQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionTemplateConnection, StandardMetafieldDefinitionTemplatesOperationQueryBuilder>, IGraphOperationQueryBuilder<StandardMetafieldDefinitionTemplateConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public StandardMetafieldDefinitionTemplatesArgumentsBuilder Arguments { get; }
        protected override StandardMetafieldDefinitionTemplatesOperationQueryBuilder Self => this;

        public StandardMetafieldDefinitionTemplatesOperationQueryBuilder() : this("standardMetafieldDefinitionTemplates")
        {
        }

        public StandardMetafieldDefinitionTemplatesOperationQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionTemplateConnection>(name))
        {
            Arguments = new StandardMetafieldDefinitionTemplatesArgumentsBuilder(base.InnerQuery);
        }

        public StandardMetafieldDefinitionTemplatesOperationQueryBuilder(IQuery<StandardMetafieldDefinitionTemplateConnection> query) : base(query)
        {
            Arguments = new StandardMetafieldDefinitionTemplatesArgumentsBuilder(base.InnerQuery);
        }

        public StandardMetafieldDefinitionTemplatesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateEdgeQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplateEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplateEdge>(query);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplate>(query);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}