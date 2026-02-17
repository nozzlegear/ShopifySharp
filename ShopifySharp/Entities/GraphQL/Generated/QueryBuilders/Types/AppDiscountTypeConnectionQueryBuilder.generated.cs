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
    public sealed class AppDiscountTypeConnectionQueryBuilder : FieldsQueryBuilderBase<AppDiscountTypeConnection, AppDiscountTypeConnectionQueryBuilder>
    {
        protected override AppDiscountTypeConnectionQueryBuilder Self => this;

        public AppDiscountTypeConnectionQueryBuilder() : this("appDiscountTypeConnection")
        {
        }

        public AppDiscountTypeConnectionQueryBuilder(string name) : base(new Query<AppDiscountTypeConnection>(name))
        {
        }

        public AppDiscountTypeConnectionQueryBuilder(IQuery<AppDiscountTypeConnection> query) : base(query)
        {
        }

        public AppDiscountTypeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeEdgeQueryBuilder> build)
        {
            var query = new Query<AppDiscountTypeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountTypeEdge>(query);
            return this;
        }

        public AppDiscountTypeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }

        public AppDiscountTypeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}