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
    public sealed class CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodSendUpdateEmailPayload, CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder Self => this;

        public CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder() : this("customerPaymentMethodSendUpdateEmailPayload")
        {
        }

        public CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodSendUpdateEmailPayload>(name))
        {
        }

        public CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder(IQuery<CustomerPaymentMethodSendUpdateEmailPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerPaymentMethodSendUpdateEmailPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}