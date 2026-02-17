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
    public sealed class ShippingLineConnectionQueryBuilder : FieldsQueryBuilderBase<ShippingLineConnection, ShippingLineConnectionQueryBuilder>
    {
        protected override ShippingLineConnectionQueryBuilder Self => this;

        public ShippingLineConnectionQueryBuilder() : this("shippingLineConnection")
        {
        }

        public ShippingLineConnectionQueryBuilder(string name) : base(new Query<ShippingLineConnection>(name))
        {
        }

        public ShippingLineConnectionQueryBuilder(IQuery<ShippingLineConnection> query) : base(query)
        {
        }

        public ShippingLineConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineEdgeQueryBuilder> build)
        {
            var query = new Query<ShippingLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineEdge>(query);
            return this;
        }

        public ShippingLineConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public ShippingLineConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}