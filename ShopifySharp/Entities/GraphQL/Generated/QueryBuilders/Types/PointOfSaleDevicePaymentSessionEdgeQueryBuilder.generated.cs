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
    public sealed class PointOfSaleDevicePaymentSessionEdgeQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionEdge, PointOfSaleDevicePaymentSessionEdgeQueryBuilder>
    {
        protected override PointOfSaleDevicePaymentSessionEdgeQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionEdgeQueryBuilder() : this("pointOfSaleDevicePaymentSessionEdge")
        {
        }

        public PointOfSaleDevicePaymentSessionEdgeQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionEdge>(name))
        {
        }

        public PointOfSaleDevicePaymentSessionEdgeQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionEdge> query) : base(query)
        {
        }

        public PointOfSaleDevicePaymentSessionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PointOfSaleDevicePaymentSessionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }
    }
}