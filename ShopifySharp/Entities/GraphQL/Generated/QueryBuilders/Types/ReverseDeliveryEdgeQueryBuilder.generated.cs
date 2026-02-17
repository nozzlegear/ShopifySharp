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
    public sealed class ReverseDeliveryEdgeQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryEdge, ReverseDeliveryEdgeQueryBuilder>
    {
        protected override ReverseDeliveryEdgeQueryBuilder Self => this;

        public ReverseDeliveryEdgeQueryBuilder() : this("reverseDeliveryEdge")
        {
        }

        public ReverseDeliveryEdgeQueryBuilder(string name) : base(new Query<ReverseDeliveryEdge>(name))
        {
        }

        public ReverseDeliveryEdgeQueryBuilder(IQuery<ReverseDeliveryEdge> query) : base(query)
        {
        }

        public ReverseDeliveryEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReverseDeliveryEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }
    }
}