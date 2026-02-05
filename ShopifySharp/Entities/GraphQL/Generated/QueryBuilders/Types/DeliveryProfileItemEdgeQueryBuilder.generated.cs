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
    public sealed class DeliveryProfileItemEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileItemEdge, DeliveryProfileItemEdgeQueryBuilder>
    {
        protected override DeliveryProfileItemEdgeQueryBuilder Self => this;

        public DeliveryProfileItemEdgeQueryBuilder() : this("deliveryProfileItemEdge")
        {
        }

        public DeliveryProfileItemEdgeQueryBuilder(string name) : base(new Query<DeliveryProfileItemEdge>(name))
        {
        }

        public DeliveryProfileItemEdgeQueryBuilder(IQuery<DeliveryProfileItemEdge> query) : base(query)
        {
        }

        public DeliveryProfileItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryProfileItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItem>(query);
            return this;
        }
    }
}