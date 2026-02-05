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
    public sealed class PaymentReminderSendOperationQueryBuilder : FieldsQueryBuilderBase<PaymentReminderSendPayload, PaymentReminderSendOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentReminderSendPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentReminderSendArgumentsBuilder Arguments { get; }
        protected override PaymentReminderSendOperationQueryBuilder Self => this;

        public PaymentReminderSendOperationQueryBuilder() : this("paymentReminderSend")
        {
        }

        public PaymentReminderSendOperationQueryBuilder(string name) : base(new Query<PaymentReminderSendPayload>(name))
        {
            Arguments = new PaymentReminderSendArgumentsBuilder(base.InnerQuery);
        }

        public PaymentReminderSendOperationQueryBuilder(IQuery<PaymentReminderSendPayload> query) : base(query)
        {
            Arguments = new PaymentReminderSendArgumentsBuilder(base.InnerQuery);
        }

        public PaymentReminderSendOperationQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public PaymentReminderSendOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentReminderSendUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentReminderSendUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentReminderSendUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentReminderSendUserError>(query);
            return this;
        }
    }
}