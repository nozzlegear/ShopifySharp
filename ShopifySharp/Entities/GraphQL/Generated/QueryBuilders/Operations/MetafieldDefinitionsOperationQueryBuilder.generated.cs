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
    public sealed class MetafieldDefinitionsOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConnection, MetafieldDefinitionsOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MetafieldDefinitionsArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionsOperationQueryBuilder Self => this;

        public MetafieldDefinitionsOperationQueryBuilder() : this("metafieldDefinitions")
        {
        }

        public MetafieldDefinitionsOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionConnection>(name))
        {
            Arguments = new MetafieldDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionsOperationQueryBuilder(IQuery<MetafieldDefinitionConnection> query) : base(query)
        {
            Arguments = new MetafieldDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionEdge>(query);
            return this;
        }

        public MetafieldDefinitionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}