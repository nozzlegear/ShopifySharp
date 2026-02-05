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
    public sealed class ReverseDeliveryLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryLineItemEdge, ReverseDeliveryLineItemEdgeQueryBuilder>
    {
        protected override ReverseDeliveryLineItemEdgeQueryBuilder Self => this;

        public ReverseDeliveryLineItemEdgeQueryBuilder() : this("reverseDeliveryLineItemEdge")
        {
        }

        public ReverseDeliveryLineItemEdgeQueryBuilder(string name) : base(new Query<ReverseDeliveryLineItemEdge>(name))
        {
        }

        public ReverseDeliveryLineItemEdgeQueryBuilder(IQuery<ReverseDeliveryLineItemEdge> query) : base(query)
        {
        }

        public ReverseDeliveryLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReverseDeliveryLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItem>(query);
            return this;
        }
    }
}