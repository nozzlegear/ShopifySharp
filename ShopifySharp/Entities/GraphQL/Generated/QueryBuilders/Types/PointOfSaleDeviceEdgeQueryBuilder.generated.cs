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
    public sealed class PointOfSaleDeviceEdgeQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDeviceEdge, PointOfSaleDeviceEdgeQueryBuilder>
    {
        protected override PointOfSaleDeviceEdgeQueryBuilder Self => this;

        public PointOfSaleDeviceEdgeQueryBuilder() : this("pointOfSaleDeviceEdge")
        {
        }

        public PointOfSaleDeviceEdgeQueryBuilder(string name) : base(new Query<PointOfSaleDeviceEdge>(name))
        {
        }

        public PointOfSaleDeviceEdgeQueryBuilder(IQuery<PointOfSaleDeviceEdge> query) : base(query)
        {
        }

        public PointOfSaleDeviceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PointOfSaleDeviceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }
    }
}