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
    public sealed class CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodSendUpdateEmailPayload, CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodSendUpdateEmailPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodSendUpdateEmailArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder Self => this;

        public CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder() : this("customerPaymentMethodSendUpdateEmail")
        {
        }

        public CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodSendUpdateEmailPayload>(name))
        {
            Arguments = new CustomerPaymentMethodSendUpdateEmailArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder(IQuery<CustomerPaymentMethodSendUpdateEmailPayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodSendUpdateEmailArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerPaymentMethodSendUpdateEmailOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}