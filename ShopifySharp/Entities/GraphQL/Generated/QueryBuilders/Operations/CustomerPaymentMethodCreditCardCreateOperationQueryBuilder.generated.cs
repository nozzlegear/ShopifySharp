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
    public sealed class CustomerPaymentMethodCreditCardCreateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodCreditCardCreatePayload, CustomerPaymentMethodCreditCardCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodCreditCardCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodCreditCardCreateArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodCreditCardCreateOperationQueryBuilder Self => this;

        public CustomerPaymentMethodCreditCardCreateOperationQueryBuilder() : this("customerPaymentMethodCreditCardCreate")
        {
        }

        public CustomerPaymentMethodCreditCardCreateOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodCreditCardCreatePayload>(name))
        {
            Arguments = new CustomerPaymentMethodCreditCardCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodCreditCardCreateOperationQueryBuilder(IQuery<CustomerPaymentMethodCreditCardCreatePayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodCreditCardCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodCreditCardCreateOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodCreditCardCreateOperationQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public CustomerPaymentMethodCreditCardCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}