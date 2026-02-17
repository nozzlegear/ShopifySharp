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
    public sealed class AppPurchaseOneTimeConnectionQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTimeConnection, AppPurchaseOneTimeConnectionQueryBuilder>
    {
        protected override AppPurchaseOneTimeConnectionQueryBuilder Self => this;

        public AppPurchaseOneTimeConnectionQueryBuilder() : this("appPurchaseOneTimeConnection")
        {
        }

        public AppPurchaseOneTimeConnectionQueryBuilder(string name) : base(new Query<AppPurchaseOneTimeConnection>(name))
        {
        }

        public AppPurchaseOneTimeConnectionQueryBuilder(IQuery<AppPurchaseOneTimeConnection> query) : base(query)
        {
        }

        public AppPurchaseOneTimeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeEdgeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTimeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTimeEdge>(query);
            return this;
        }

        public AppPurchaseOneTimeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTime>(query);
            return this;
        }

        public AppPurchaseOneTimeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}