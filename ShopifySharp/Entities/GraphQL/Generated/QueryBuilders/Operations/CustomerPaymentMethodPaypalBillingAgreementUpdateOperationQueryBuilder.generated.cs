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

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodUserError>(query);
            return this;
        }
    }
}