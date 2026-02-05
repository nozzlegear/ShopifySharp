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
    public sealed class GiftCardSendNotificationToCustomerUserErrorQueryBuilder : FieldsQueryBuilderBase<GiftCardSendNotificationToCustomerUserError, GiftCardSendNotificationToCustomerUserErrorQueryBuilder>
    {
        protected override GiftCardSendNotificationToCustomerUserErrorQueryBuilder Self => this;

        public GiftCardSendNotificationToCustomerUserErrorQueryBuilder() : this("giftCardSendNotificationToCustomerUserError")
        {
        }

        public GiftCardSendNotificationToCustomerUserErrorQueryBuilder(string name) : base(new Query<GiftCardSendNotificationToCustomerUserError>(name))
        {
        }

        public GiftCardSendNotificationToCustomerUserErrorQueryBuilder(IQuery<GiftCardSendNotificationToCustomerUserError> query) : base(query)
        {
        }

        public GiftCardSendNotificationToCustomerUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public GiftCardSendNotificationToCustomerUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public GiftCardSendNotificationToCustomerUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}