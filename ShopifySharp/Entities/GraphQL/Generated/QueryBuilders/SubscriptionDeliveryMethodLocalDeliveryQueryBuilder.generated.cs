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

public class SubscriptionDeliveryMethodLocalDeliveryQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodLocalDelivery>("subscriptionDeliveryMethodLocalDelivery")
{
    public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder AddFieldAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("address", build);
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder AddFieldLocalDeliveryOption(Func<SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder, SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder> build)
    {
        AddField<SubscriptionDeliveryMethodLocalDeliveryOption, SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder>("localDeliveryOption", build);
        return this;
    }
}