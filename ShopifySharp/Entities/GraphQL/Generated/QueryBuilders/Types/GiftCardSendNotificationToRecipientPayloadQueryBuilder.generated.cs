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
    public sealed class GiftCardSendNotificationToRecipientPayloadQueryBuilder : FieldsQueryBuilderBase<GiftCardSendNotificationToRecipientPayload, GiftCardSendNotificationToRecipientPayloadQueryBuilder>
    {
        protected override GiftCardSendNotificationToRecipientPayloadQueryBuilder Self => this;

        public GiftCardSendNotificationToRecipientPayloadQueryBuilder() : this("giftCardSendNotificationToRecipientPayload")
        {
        }

        public GiftCardSendNotificationToRecipientPayloadQueryBuilder(string name) : base(new Query<GiftCardSendNotificationToRecipientPayload>(name))
        {
        }

        public GiftCardSendNotificationToRecipientPayloadQueryBuilder(IQuery<GiftCardSendNotificationToRecipientPayload> query) : base(query)
        {
        }

        public GiftCardSendNotificationToRecipientPayloadQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardSendNotificationToRecipientPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardSendNotificationToRecipientUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardSendNotificationToRecipientUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardSendNotificationToRecipientUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardSendNotificationToRecipientUserError>(query);
            return this;
        }
    }
}