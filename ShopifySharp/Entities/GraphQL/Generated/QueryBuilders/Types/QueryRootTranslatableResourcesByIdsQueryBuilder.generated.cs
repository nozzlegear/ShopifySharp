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
    public sealed class QueryRootTranslatableResourcesByIdsQueryBuilder : FieldsQueryBuilderBase<TranslatableResourceConnection, QueryRootTranslatableResourcesByIdsQueryBuilder>, IHasArguments<QueryRootTranslatableResourcesByIdsArgumentsBuilder>
    {
        public QueryRootTranslatableResourcesByIdsArgumentsBuilder Arguments { get; }
        protected override QueryRootTranslatableResourcesByIdsQueryBuilder Self => this;

        public QueryRootTranslatableResourcesByIdsQueryBuilder(string name) : base(new Query<TranslatableResourceConnection>(name))
        {
            Arguments = new QueryRootTranslatableResourcesByIdsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootTranslatableResourcesByIdsQueryBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
            Arguments = new QueryRootTranslatableResourcesByIdsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootTranslatableResourcesByIdsQueryBuilder SetArguments(Action<QueryRootTranslatableResourcesByIdsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceEdge>(query);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}