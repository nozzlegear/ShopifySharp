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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionDeliveryMethodUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionDeliveryMethod, SubscriptionDeliveryMethodUnionCasesBuilder>
    {
        protected override SubscriptionDeliveryMethodUnionCasesBuilder Self => this;

        public SubscriptionDeliveryMethodUnionCasesBuilder(string fieldName = "deliveryMethod") : this(new Query<SubscriptionDeliveryMethod>(fieldName))
        {
        }

        public SubscriptionDeliveryMethodUnionCasesBuilder(IQuery<SubscriptionDeliveryMethod> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodUnionCasesBuilder OnSubscriptionDeliveryMethodLocalDelivery(Action<SubscriptionDeliveryMethodLocalDeliveryQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethodLocalDelivery>("... on SubscriptionDeliveryMethodLocalDelivery");
            var queryBuilder = new SubscriptionDeliveryMethodLocalDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDeliveryMethodUnionCasesBuilder OnSubscriptionDeliveryMethodPickup(Action<SubscriptionDeliveryMethodPickupQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethodPickup>("... on SubscriptionDeliveryMethodPickup");
            var queryBuilder = new SubscriptionDeliveryMethodPickupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDeliveryMethodUnionCasesBuilder OnSubscriptionDeliveryMethodShipping(Action<SubscriptionDeliveryMethodShippingQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethodShipping>("... on SubscriptionDeliveryMethodShipping");
            var queryBuilder = new SubscriptionDeliveryMethodShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}