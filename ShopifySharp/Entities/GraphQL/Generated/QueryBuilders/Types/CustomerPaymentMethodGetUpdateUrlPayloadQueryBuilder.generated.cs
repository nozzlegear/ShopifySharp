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
    public sealed class CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodGetUpdateUrlPayload, CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder Self => this;

        public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder() : this("customerPaymentMethodGetUpdateUrlPayload")
        {
        }

        public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodGetUpdateUrlPayload>(name))
        {
        }

        public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder(IQuery<CustomerPaymentMethodGetUpdateUrlPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder UpdatePaymentMethodUrl()
        {
            base.InnerQuery.AddField("updatePaymentMethodUrl");
            return this;
        }

        public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodGetUpdateUrlUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodGetUpdateUrlUserError>(query);
            return this;
        }
    }
}