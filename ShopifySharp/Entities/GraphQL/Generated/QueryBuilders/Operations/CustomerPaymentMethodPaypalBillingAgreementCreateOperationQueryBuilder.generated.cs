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
    public sealed class CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodPaypalBillingAgreementCreatePayload, CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodPaypalBillingAgreementCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder Self => this;

        public CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder() : this("customerPaymentMethodPaypalBillingAgreementCreate")
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodPaypalBillingAgreementCreatePayload>(name))
        {
            Arguments = new CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder(IQuery<CustomerPaymentMethodPaypalBillingAgreementCreatePayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodUserError>(query);
            return this;
        }
    }
}