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
    public sealed class SubscriptionDraftShippingOptionsArgumentsBuilder : ArgumentsBuilderBase<SubscriptionShippingOptionResult?, SubscriptionDraftShippingOptionsArgumentsBuilder>
    {
        protected override SubscriptionDraftShippingOptionsArgumentsBuilder Self => this;

        public SubscriptionDraftShippingOptionsArgumentsBuilder(IQuery<SubscriptionShippingOptionResult?> query) : base(query)
        {
        }

        public SubscriptionDraftShippingOptionsArgumentsBuilder DeliveryAddress(MailingAddressInput? deliveryAddress)
        {
            base.InnerQuery.AddArgument("deliveryAddress", deliveryAddress);
            return this;
        }
    }
}