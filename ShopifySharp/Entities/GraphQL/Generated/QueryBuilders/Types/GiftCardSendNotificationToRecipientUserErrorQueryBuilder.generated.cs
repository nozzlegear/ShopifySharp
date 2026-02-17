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
    public sealed class GiftCardSendNotificationToRecipientUserErrorQueryBuilder : FieldsQueryBuilderBase<GiftCardSendNotificationToRecipientUserError, GiftCardSendNotificationToRecipientUserErrorQueryBuilder>
    {
        protected override GiftCardSendNotificationToRecipientUserErrorQueryBuilder Self => this;

        public GiftCardSendNotificationToRecipientUserErrorQueryBuilder() : this("giftCardSendNotificationToRecipientUserError")
        {
        }

        public GiftCardSendNotificationToRecipientUserErrorQueryBuilder(string name) : base(new Query<GiftCardSendNotificationToRecipientUserError>(name))
        {
        }

        public GiftCardSendNotificationToRecipientUserErrorQueryBuilder(IQuery<GiftCardSendNotificationToRecipientUserError> query) : base(query)
        {
        }

        public GiftCardSendNotificationToRecipientUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public GiftCardSendNotificationToRecipientUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public GiftCardSendNotificationToRecipientUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}