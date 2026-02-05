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
    public sealed class GiftCardSendNotificationToCustomerPayloadQueryBuilder : FieldsQueryBuilderBase<GiftCardSendNotificationToCustomerPayload, GiftCardSendNotificationToCustomerPayloadQueryBuilder>
    {
        protected override GiftCardSendNotificationToCustomerPayloadQueryBuilder Self => this;

        public GiftCardSendNotificationToCustomerPayloadQueryBuilder() : this("giftCardSendNotificationToCustomerPayload")
        {
        }

        public GiftCardSendNotificationToCustomerPayloadQueryBuilder(string name) : base(new Query<GiftCardSendNotificationToCustomerPayload>(name))
        {
        }

        public GiftCardSendNotificationToCustomerPayloadQueryBuilder(IQuery<GiftCardSendNotificationToCustomerPayload> query) : base(query)
        {
        }

        public GiftCardSendNotificationToCustomerPayloadQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardSendNotificationToCustomerPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardSendNotificationToCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardSendNotificationToCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardSendNotificationToCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardSendNotificationToCustomerUserError>(query);
            return this;
        }
    }
}