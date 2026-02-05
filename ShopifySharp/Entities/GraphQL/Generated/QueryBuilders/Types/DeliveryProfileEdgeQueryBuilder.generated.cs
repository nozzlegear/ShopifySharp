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
    public sealed class DeliveryProfileEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileEdge, DeliveryProfileEdgeQueryBuilder>
    {
        protected override DeliveryProfileEdgeQueryBuilder Self => this;

        public DeliveryProfileEdgeQueryBuilder() : this("deliveryProfileEdge")
        {
        }

        public DeliveryProfileEdgeQueryBuilder(string name) : base(new Query<DeliveryProfileEdge>(name))
        {
        }

        public DeliveryProfileEdgeQueryBuilder(IQuery<DeliveryProfileEdge> query) : base(query)
        {
        }

        public DeliveryProfileEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryProfileEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }
    }
}