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
    public sealed class QueryRootReturnReasonDefinitionsQueryBuilder : FieldsQueryBuilderBase<ReturnReasonDefinitionConnection, QueryRootReturnReasonDefinitionsQueryBuilder>, IHasArguments<QueryRootReturnReasonDefinitionsArgumentsBuilder>
    {
        public QueryRootReturnReasonDefinitionsArgumentsBuilder Arguments { get; }
        protected override QueryRootReturnReasonDefinitionsQueryBuilder Self => this;

        public QueryRootReturnReasonDefinitionsQueryBuilder(string name) : base(new Query<ReturnReasonDefinitionConnection>(name))
        {
            Arguments = new QueryRootReturnReasonDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnReasonDefinitionsQueryBuilder(IQuery<ReturnReasonDefinitionConnection> query) : base(query)
        {
            Arguments = new QueryRootReturnReasonDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnReasonDefinitionsQueryBuilder SetArguments(Action<QueryRootReturnReasonDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootReturnReasonDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionEdge>(query);
            return this;
        }

        public QueryRootReturnReasonDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public QueryRootReturnReasonDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}