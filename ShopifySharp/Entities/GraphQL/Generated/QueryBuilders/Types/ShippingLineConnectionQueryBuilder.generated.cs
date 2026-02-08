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

        public ShippingLineConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineEdgeQueryBuilder> build)
        {
            var query = new Query<ShippingLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineEdge>(query);
            return this;
        }

        public ShippingLineConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public ShippingLineConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}