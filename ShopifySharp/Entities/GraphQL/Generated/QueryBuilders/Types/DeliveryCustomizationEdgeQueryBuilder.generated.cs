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
    public sealed class DeliveryCustomizationEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationEdge, DeliveryCustomizationEdgeQueryBuilder>
    {
        protected override DeliveryCustomizationEdgeQueryBuilder Self => this;

        public DeliveryCustomizationEdgeQueryBuilder() : this("deliveryCustomizationEdge")
        {
        }

        public DeliveryCustomizationEdgeQueryBuilder(string name) : base(new Query<DeliveryCustomizationEdge>(name))
        {
        }

        public DeliveryCustomizationEdgeQueryBuilder(IQuery<DeliveryCustomizationEdge> query) : base(query)
        {
        }

        public DeliveryCustomizationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryCustomizationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }
    }
}