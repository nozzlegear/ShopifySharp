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
    public sealed class ReverseDeliveryShippingDeliverableQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryShippingDeliverable, ReverseDeliveryShippingDeliverableQueryBuilder>
    {
        protected override ReverseDeliveryShippingDeliverableQueryBuilder Self => this;

        public ReverseDeliveryShippingDeliverableQueryBuilder() : this("reverseDeliveryShippingDeliverable")
        {
        }

        public ReverseDeliveryShippingDeliverableQueryBuilder(string name) : base(new Query<ReverseDeliveryShippingDeliverable>(name))
        {
        }

        public ReverseDeliveryShippingDeliverableQueryBuilder(IQuery<ReverseDeliveryShippingDeliverable> query) : base(query)
        {
        }

        public ReverseDeliveryShippingDeliverableQueryBuilder Label(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryLabelV2QueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLabelV2>("label");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryLabelV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLabelV2>(query);
            return this;
        }

        public ReverseDeliveryShippingDeliverableQueryBuilder Tracking(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryTrackingV2QueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryTrackingV2>("tracking");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryTrackingV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryTrackingV2>(query);
            return this;
        }
    }
}