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
    public sealed class MetaobjectDefinitionsOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionConnection, MetaobjectDefinitionsOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectDefinitionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MetaobjectDefinitionsArgumentsBuilder Arguments { get; }
        protected override MetaobjectDefinitionsOperationQueryBuilder Self => this;

        public MetaobjectDefinitionsOperationQueryBuilder() : this("metaobjectDefinitions")
        {
        }

        public MetaobjectDefinitionsOperationQueryBuilder(string name) : base(new Query<MetaobjectDefinitionConnection>(name))
        {
            Arguments = new MetaobjectDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionsOperationQueryBuilder(IQuery<MetaobjectDefinitionConnection> query) : base(query)
        {
            Arguments = new MetaobjectDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinitionEdge>(query);
            return this;
        }

        public MetaobjectDefinitionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public MetaobjectDefinitionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}