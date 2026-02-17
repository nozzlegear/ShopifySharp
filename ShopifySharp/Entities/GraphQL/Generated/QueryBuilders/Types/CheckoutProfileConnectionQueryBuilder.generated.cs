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
    public sealed class CheckoutProfileConnectionQueryBuilder : FieldsQueryBuilderBase<CheckoutProfileConnection, CheckoutProfileConnectionQueryBuilder>
    {
        protected override CheckoutProfileConnectionQueryBuilder Self => this;

        public CheckoutProfileConnectionQueryBuilder() : this("checkoutProfileConnection")
        {
        }

        public CheckoutProfileConnectionQueryBuilder(string name) : base(new Query<CheckoutProfileConnection>(name))
        {
        }

        public CheckoutProfileConnectionQueryBuilder(IQuery<CheckoutProfileConnection> query) : base(query)
        {
        }

        public CheckoutProfileConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileEdgeQueryBuilder> build)
        {
            var query = new Query<CheckoutProfileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfileEdge>(query);
            return this;
        }

        public CheckoutProfileConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileQueryBuilder> build)
        {
            var query = new Query<CheckoutProfile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfile>(query);
            return this;
        }

        public CheckoutProfileConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}