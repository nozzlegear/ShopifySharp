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
    public sealed class PaymentCustomizationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationUpdatePayload, PaymentCustomizationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentCustomizationUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentCustomizationUpdateArgumentsBuilder Arguments { get; }
        protected override PaymentCustomizationUpdateOperationQueryBuilder Self => this;

        public PaymentCustomizationUpdateOperationQueryBuilder() : this("paymentCustomizationUpdate")
        {
        }

        public PaymentCustomizationUpdateOperationQueryBuilder(string name) : base(new Query<PaymentCustomizationUpdatePayload>(name))
        {
            Arguments = new PaymentCustomizationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationUpdateOperationQueryBuilder(IQuery<PaymentCustomizationUpdatePayload> query) : base(query)
        {
            Arguments = new PaymentCustomizationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationUpdateOperationQueryBuilder PaymentCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("paymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}