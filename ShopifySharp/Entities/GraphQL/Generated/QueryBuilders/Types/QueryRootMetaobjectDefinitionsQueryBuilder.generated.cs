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
    public sealed class QueryRootMetaobjectDefinitionsQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionConnection, QueryRootMetaobjectDefinitionsQueryBuilder>, IHasArguments<QueryRootMetaobjectDefinitionsArgumentsBuilder>
    {
        public QueryRootMetaobjectDefinitionsArgumentsBuilder Arguments { get; }
        protected override QueryRootMetaobjectDefinitionsQueryBuilder Self => this;

        public QueryRootMetaobjectDefinitionsQueryBuilder(string name) : base(new Query<MetaobjectDefinitionConnection>(name))
        {
            Arguments = new QueryRootMetaobjectDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetaobjectDefinitionsQueryBuilder(IQuery<MetaobjectDefinitionConnection> query) : base(query)
        {
            Arguments = new QueryRootMetaobjectDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetaobjectDefinitionsQueryBuilder SetArguments(Action<QueryRootMetaobjectDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMetaobjectDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinitionEdge>(query);
            return this;
        }

        public QueryRootMetaobjectDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public QueryRootMetaobjectDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}