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
    public sealed class SubscriptionDeliveryOptionResultArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDeliveryOptionResult, SubscriptionDeliveryOptionResultArgumentsBuilder>
    {
        protected override SubscriptionDeliveryOptionResultArgumentsBuilder Self => this;

        public SubscriptionDeliveryOptionResultArgumentsBuilder(IQuery<SubscriptionDeliveryOptionResult> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionResultArgumentsBuilder DeliveryAddress(MailingAddressInput? deliveryAddress)
        {
            base.InnerQuery.AddArgument("deliveryAddress", deliveryAddress);
            return this;
        }
    }
}