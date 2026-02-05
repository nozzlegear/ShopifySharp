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
    public sealed class CustomerPaymentMethodRemoteCreateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodRemoteCreatePayload, CustomerPaymentMethodRemoteCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodRemoteCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodRemoteCreateArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodRemoteCreateOperationQueryBuilder Self => this;

        public CustomerPaymentMethodRemoteCreateOperationQueryBuilder() : this("customerPaymentMethodRemoteCreate")
        {
        }

        public CustomerPaymentMethodRemoteCreateOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodRemoteCreatePayload>(name))
        {
            Arguments = new CustomerPaymentMethodRemoteCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodRemoteCreateOperationQueryBuilder(IQuery<CustomerPaymentMethodRemoteCreatePayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodRemoteCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodRemoteCreateOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodRemoteCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodRemoteUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodRemoteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodRemoteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodRemoteUserError>(query);
            return this;
        }
    }
}