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
    public sealed class CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodCreditCardUpdatePayload, CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodCreditCardUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodCreditCardUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder Self => this;

        public CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder() : this("customerPaymentMethodCreditCardUpdate")
        {
        }

        public CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodCreditCardUpdatePayload>(name))
        {
            Arguments = new CustomerPaymentMethodCreditCardUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder(IQuery<CustomerPaymentMethodCreditCardUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodCreditCardUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public CustomerPaymentMethodCreditCardUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}