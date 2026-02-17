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
    public sealed class PaymentReminderSendUserErrorQueryBuilder : FieldsQueryBuilderBase<PaymentReminderSendUserError, PaymentReminderSendUserErrorQueryBuilder>
    {
        protected override PaymentReminderSendUserErrorQueryBuilder Self => this;

        public PaymentReminderSendUserErrorQueryBuilder() : this("paymentReminderSendUserError")
        {
        }

        public PaymentReminderSendUserErrorQueryBuilder(string name) : base(new Query<PaymentReminderSendUserError>(name))
        {
        }

        public PaymentReminderSendUserErrorQueryBuilder(IQuery<PaymentReminderSendUserError> query) : base(query)
        {
        }

        public PaymentReminderSendUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PaymentReminderSendUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PaymentReminderSendUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}