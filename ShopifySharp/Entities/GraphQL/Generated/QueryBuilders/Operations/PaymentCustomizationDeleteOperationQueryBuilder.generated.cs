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
    public sealed class PaymentCustomizationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationDeletePayload, PaymentCustomizationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentCustomizationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentCustomizationDeleteArgumentsBuilder Arguments { get; }
        protected override PaymentCustomizationDeleteOperationQueryBuilder Self => this;

        public PaymentCustomizationDeleteOperationQueryBuilder() : this("paymentCustomizationDelete")
        {
        }

        public PaymentCustomizationDeleteOperationQueryBuilder(string name) : base(new Query<PaymentCustomizationDeletePayload>(name))
        {
            Arguments = new PaymentCustomizationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationDeleteOperationQueryBuilder(IQuery<PaymentCustomizationDeletePayload> query) : base(query)
        {
            Arguments = new PaymentCustomizationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PaymentCustomizationDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}