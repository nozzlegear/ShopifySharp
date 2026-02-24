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
    public sealed class QueryRootMetaobjectsQueryBuilder : FieldsQueryBuilderBase<MetaobjectConnection, QueryRootMetaobjectsQueryBuilder>, IHasArguments<QueryRootMetaobjectsArgumentsBuilder>
    {
        public QueryRootMetaobjectsArgumentsBuilder Arguments { get; }
        protected override QueryRootMetaobjectsQueryBuilder Self => this;

        public QueryRootMetaobjectsQueryBuilder(string name) : base(new Query<MetaobjectConnection>(name))
        {
            Arguments = new QueryRootMetaobjectsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetaobjectsQueryBuilder(IQuery<MetaobjectConnection> query) : base(query)
        {
            Arguments = new QueryRootMetaobjectsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetaobjectsQueryBuilder SetArguments(Action<QueryRootMetaobjectsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMetaobjectsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectEdge>(query);
            return this;
        }

        public QueryRootMetaobjectsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public QueryRootMetaobjectsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}