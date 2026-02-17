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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class GiftCardSendNotificationToRecipientOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardSendNotificationToRecipientPayload, GiftCardSendNotificationToRecipientOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardSendNotificationToRecipientPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardSendNotificationToRecipientArgumentsBuilder Arguments { get; }
        protected override GiftCardSendNotificationToRecipientOperationQueryBuilder Self => this;

        public GiftCardSendNotificationToRecipientOperationQueryBuilder() : this("giftCardSendNotificationToRecipient")
        {
        }

        public GiftCardSendNotificationToRecipientOperationQueryBuilder(string name) : base(new Query<GiftCardSendNotificationToRecipientPayload>(name))
        {
            Arguments = new GiftCardSendNotificationToRecipientArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardSendNotificationToRecipientOperationQueryBuilder(IQuery<GiftCardSendNotificationToRecipientPayload> query) : base(query)
        {
            Arguments = new GiftCardSendNotificationToRecipientArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardSendNotificationToRecipientOperationQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardSendNotificationToRecipientOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSendNotificationToRecipientUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardSendNotificationToRecipientUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSendNotificationToRecipientUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardSendNotificationToRecipientUserError>(query);
            return this;
        }
    }
}