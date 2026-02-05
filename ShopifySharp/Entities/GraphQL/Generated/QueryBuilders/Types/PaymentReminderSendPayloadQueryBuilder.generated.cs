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
    public sealed class PaymentReminderSendPayloadQueryBuilder : FieldsQueryBuilderBase<PaymentReminderSendPayload, PaymentReminderSendPayloadQueryBuilder>
    {
        protected override PaymentReminderSendPayloadQueryBuilder Self => this;

        public PaymentReminderSendPayloadQueryBuilder() : this("paymentReminderSendPayload")
        {
        }

        public PaymentReminderSendPayloadQueryBuilder(string name) : base(new Query<PaymentReminderSendPayload>(name))
        {
        }

        public PaymentReminderSendPayloadQueryBuilder(IQuery<PaymentReminderSendPayload> query) : base(query)
        {
        }

        public PaymentReminderSendPayloadQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public PaymentReminderSendPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentReminderSendUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentReminderSendUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentReminderSendUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentReminderSendUserError>(query);
            return this;
        }
    }
}