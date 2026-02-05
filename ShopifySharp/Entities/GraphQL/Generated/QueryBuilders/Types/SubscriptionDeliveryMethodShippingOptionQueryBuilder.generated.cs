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
    public sealed class SubscriptionDeliveryMethodShippingOptionQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethodShippingOption, SubscriptionDeliveryMethodShippingOptionQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodShippingOptionQueryBuilder Self => this;

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder() : this("subscriptionDeliveryMethodShippingOption")
        {
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethodShippingOption>(name))
        {
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder(IQuery<SubscriptionDeliveryMethodShippingOption> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder PresentmentTitle()
        {
            base.InnerQuery.AddField("presentmentTitle");
            return this;
        }

        public SubscriptionDeliveryMethodShippingOptionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}