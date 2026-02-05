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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CustomerPaymentMethodRevokePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodRevokePayload, CustomerPaymentMethodRevokePayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodRevokePayloadQueryBuilder Self => this;

        public CustomerPaymentMethodRevokePayloadQueryBuilder() : this("customerPaymentMethodRevokePayload")
        {
        }

        public CustomerPaymentMethodRevokePayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodRevokePayload>(name))
        {
        }

        public CustomerPaymentMethodRevokePayloadQueryBuilder(IQuery<CustomerPaymentMethodRevokePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodRevokePayloadQueryBuilder RevokedCustomerPaymentMethodId()
        {
            base.InnerQuery.AddField("revokedCustomerPaymentMethodId");
            return this;
        }

        public CustomerPaymentMethodRevokePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}