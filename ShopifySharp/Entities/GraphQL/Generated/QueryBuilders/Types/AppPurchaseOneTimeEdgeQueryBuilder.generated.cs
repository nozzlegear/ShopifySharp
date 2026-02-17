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
    public sealed class AppPurchaseOneTimeEdgeQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTimeEdge, AppPurchaseOneTimeEdgeQueryBuilder>
    {
        protected override AppPurchaseOneTimeEdgeQueryBuilder Self => this;

        public AppPurchaseOneTimeEdgeQueryBuilder() : this("appPurchaseOneTimeEdge")
        {
        }

        public AppPurchaseOneTimeEdgeQueryBuilder(string name) : base(new Query<AppPurchaseOneTimeEdge>(name))
        {
        }

        public AppPurchaseOneTimeEdgeQueryBuilder(IQuery<AppPurchaseOneTimeEdge> query) : base(query)
        {
        }

        public AppPurchaseOneTimeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppPurchaseOneTimeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTime>(query);
            return this;
        }
    }
}