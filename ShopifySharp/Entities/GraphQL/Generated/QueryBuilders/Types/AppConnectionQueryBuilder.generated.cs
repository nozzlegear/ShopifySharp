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
    public sealed class AppConnectionQueryBuilder : FieldsQueryBuilderBase<AppConnection, AppConnectionQueryBuilder>
    {
        protected override AppConnectionQueryBuilder Self => this;

        public AppConnectionQueryBuilder() : this("appConnection")
        {
        }

        public AppConnectionQueryBuilder(string name) : base(new Query<AppConnection>(name))
        {
        }

        public AppConnectionQueryBuilder(IQuery<AppConnection> query) : base(query)
        {
        }

        public AppConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppEdgeQueryBuilder> build)
        {
            var query = new Query<AppEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppEdge>(query);
            return this;
        }

        public AppConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}