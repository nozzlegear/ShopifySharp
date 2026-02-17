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
    public sealed class PaymentCustomizationActivationOperationQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationActivationPayload, PaymentCustomizationActivationOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentCustomizationActivationPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentCustomizationActivationArgumentsBuilder Arguments { get; }
        protected override PaymentCustomizationActivationOperationQueryBuilder Self => this;

        public PaymentCustomizationActivationOperationQueryBuilder() : this("paymentCustomizationActivation")
        {
        }

        public PaymentCustomizationActivationOperationQueryBuilder(string name) : base(new Query<PaymentCustomizationActivationPayload>(name))
        {
            Arguments = new PaymentCustomizationActivationArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationActivationOperationQueryBuilder(IQuery<PaymentCustomizationActivationPayload> query) : base(query)
        {
            Arguments = new PaymentCustomizationActivationArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationActivationOperationQueryBuilder Ids()
        {
            base.InnerQuery.AddField("ids");
            return this;
        }

        public PaymentCustomizationActivationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}