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
    public sealed class SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethodLocalDeliveryOption, SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder Self => this;

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder() : this("subscriptionDeliveryMethodLocalDeliveryOption")
        {
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethodLocalDeliveryOption>(name))
        {
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder(IQuery<SubscriptionDeliveryMethodLocalDeliveryOption> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder Instructions()
        {
            base.InnerQuery.AddField("instructions");
            return this;
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder PresentmentTitle()
        {
            base.InnerQuery.AddField("presentmentTitle");
            return this;
        }

        public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}