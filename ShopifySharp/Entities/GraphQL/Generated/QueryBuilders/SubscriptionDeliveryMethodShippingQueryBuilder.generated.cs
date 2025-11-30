#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SubscriptionDeliveryMethodShippingQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodShipping>("subscriptionDeliveryMethodShipping")
{
    public SubscriptionDeliveryMethodShippingQueryBuilder AddFieldAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("address", build);
        return this;
    }

    public SubscriptionDeliveryMethodShippingQueryBuilder AddFieldShippingOption(Func<SubscriptionDeliveryMethodShippingOptionQueryBuilder, SubscriptionDeliveryMethodShippingOptionQueryBuilder> build)
    {
        AddField<SubscriptionDeliveryMethodShippingOption, SubscriptionDeliveryMethodShippingOptionQueryBuilder>("shippingOption", build);
        return this;
    }
}