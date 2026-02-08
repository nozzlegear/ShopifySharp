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
    public sealed class GiftCardSendNotificationToRecipientArgumentsBuilder : ArgumentsBuilderBase<GiftCardSendNotificationToRecipientPayload, GiftCardSendNotificationToRecipientArgumentsBuilder>
    {
        protected override GiftCardSendNotificationToRecipientArgumentsBuilder Self => this;

        public GiftCardSendNotificationToRecipientArgumentsBuilder(IQuery<GiftCardSendNotificationToRecipientPayload> query) : base(query)
        {
        }

        public GiftCardSendNotificationToRecipientArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}