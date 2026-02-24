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
    public sealed class QueryRootProductTypesQueryBuilder : FieldsQueryBuilderBase<StringConnection, QueryRootProductTypesQueryBuilder>, IHasArguments<QueryRootProductTypesArgumentsBuilder>
    {
        public QueryRootProductTypesArgumentsBuilder Arguments { get; }
        protected override QueryRootProductTypesQueryBuilder Self => this;

        public QueryRootProductTypesQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new QueryRootProductTypesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductTypesQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new QueryRootProductTypesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductTypesQueryBuilder SetArguments(Action<QueryRootProductTypesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductTypesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public QueryRootProductTypesQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public QueryRootProductTypesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}