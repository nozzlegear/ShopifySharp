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

        public PaymentCustomizationUpdateOperationQueryBuilder PaymentCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("paymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}