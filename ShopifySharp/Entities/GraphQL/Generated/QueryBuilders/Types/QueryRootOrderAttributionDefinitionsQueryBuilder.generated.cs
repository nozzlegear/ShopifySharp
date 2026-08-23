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
    public sealed class QueryRootOrderAttributionDefinitionsQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionConnection, QueryRootOrderAttributionDefinitionsQueryBuilder>, IHasArguments<QueryRootOrderAttributionDefinitionsArgumentsBuilder>
    {
        public QueryRootOrderAttributionDefinitionsArgumentsBuilder Arguments { get; }
        protected override QueryRootOrderAttributionDefinitionsQueryBuilder Self => this;

        public QueryRootOrderAttributionDefinitionsQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionConnection>(name))
        {
            Arguments = new QueryRootOrderAttributionDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderAttributionDefinitionsQueryBuilder(IQuery<OrderAttributionDefinitionConnection> query) : base(query)
        {
            Arguments = new QueryRootOrderAttributionDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderAttributionDefinitionsQueryBuilder SetArguments(Action<QueryRootOrderAttributionDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinitionEdge>(query);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinition>(query);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}