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
    public sealed class CustomerPaymentMethodRemoteCreatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodRemoteCreatePayload, CustomerPaymentMethodRemoteCreatePayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodRemoteCreatePayloadQueryBuilder Self => this;

        public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder() : this("customerPaymentMethodRemoteCreatePayload")
        {
        }

        public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodRemoteCreatePayload>(name))
        {
        }

        public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder(IQuery<CustomerPaymentMethodRemoteCreatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodRemoteUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodRemoteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodRemoteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodRemoteUserError>(query);
            return this;
        }
    }
}