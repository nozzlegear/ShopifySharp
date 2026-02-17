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
    public sealed class CustomerPaymentMethodRevokeOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodRevokePayload, CustomerPaymentMethodRevokeOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodRevokePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodRevokeArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodRevokeOperationQueryBuilder Self => this;

        public CustomerPaymentMethodRevokeOperationQueryBuilder() : this("customerPaymentMethodRevoke")
        {
        }

        public CustomerPaymentMethodRevokeOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodRevokePayload>(name))
        {
            Arguments = new CustomerPaymentMethodRevokeArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodRevokeOperationQueryBuilder(IQuery<CustomerPaymentMethodRevokePayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodRevokeArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodRevokeOperationQueryBuilder RevokedCustomerPaymentMethodId()
        {
            base.InnerQuery.AddField("revokedCustomerPaymentMethodId");
            return this;
        }

        public CustomerPaymentMethodRevokeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}