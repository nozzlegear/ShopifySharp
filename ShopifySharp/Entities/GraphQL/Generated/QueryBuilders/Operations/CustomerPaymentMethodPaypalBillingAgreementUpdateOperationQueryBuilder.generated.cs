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
    public sealed class CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload, CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder Self => this;

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder() : this("customerPaymentMethodPaypalBillingAgreementUpdate")
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload>(name))
        {
            Arguments = new CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder(IQuery<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodUserError>(query);
            return this;
        }
    }
}