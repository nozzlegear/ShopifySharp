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

public class GiftCardRecipientQueryBuilder() : GraphQueryBuilder<GiftCardRecipient>("giftCardRecipient")
{
    public GiftCardRecipientQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public GiftCardRecipientQueryBuilder AddFieldPreferredName()
    {
        AddField("preferredName");
        return this;
    }

    public GiftCardRecipientQueryBuilder AddFieldRecipient(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("recipient", build);
        return this;
    }

    public GiftCardRecipientQueryBuilder AddFieldSendNotificationAt()
    {
        AddField("sendNotificationAt");
        return this;
    }
}