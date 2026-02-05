#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class AppCreditConnectionQueryBuilder : FieldsQueryBuilderBase<AppCreditConnection, AppCreditConnectionQueryBuilder>
    {
        protected override AppCreditConnectionQueryBuilder Self => this;

        public AppCreditConnectionQueryBuilder() : this("appCreditConnection")
        {
        }

        public AppCreditConnectionQueryBuilder(string name) : base(new Query<AppCreditConnection>(name))
        {
        }

        public AppCreditConnectionQueryBuilder(IQuery<AppCreditConnection> query) : base(query)
        {
        }

        public AppCreditConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditEdgeQueryBuilder> build)
        {
            var query = new Query<AppCreditEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCreditEdge>(query);
            return this;
        }

        public AppCreditConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditQueryBuilder> build)
        {
            var query = new Query<AppCredit>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCredit>(query);
            return this;
        }

        public AppCreditConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}