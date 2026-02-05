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
    public sealed class ShippingLineEdgeQueryBuilder : FieldsQueryBuilderBase<ShippingLineEdge, ShippingLineEdgeQueryBuilder>
    {
        protected override ShippingLineEdgeQueryBuilder Self => this;

        public ShippingLineEdgeQueryBuilder() : this("shippingLineEdge")
        {
        }

        public ShippingLineEdgeQueryBuilder(string name) : base(new Query<ShippingLineEdge>(name))
        {
        }

        public ShippingLineEdgeQueryBuilder(IQuery<ShippingLineEdge> query) : base(query)
        {
        }

        public ShippingLineEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShippingLineEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }
    }
}