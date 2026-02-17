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
    public sealed class PaymentCustomizationCreateOperationQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationCreatePayload, PaymentCustomizationCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentCustomizationCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentCustomizationCreateArgumentsBuilder Arguments { get; }
        protected override PaymentCustomizationCreateOperationQueryBuilder Self => this;

        public PaymentCustomizationCreateOperationQueryBuilder() : this("paymentCustomizationCreate")
        {
        }

        public PaymentCustomizationCreateOperationQueryBuilder(string name) : base(new Query<PaymentCustomizationCreatePayload>(name))
        {
            Arguments = new PaymentCustomizationCreateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationCreateOperationQueryBuilder(IQuery<PaymentCustomizationCreatePayload> query) : base(query)
        {
            Arguments = new PaymentCustomizationCreateArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationCreateOperationQueryBuilder PaymentCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("paymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}