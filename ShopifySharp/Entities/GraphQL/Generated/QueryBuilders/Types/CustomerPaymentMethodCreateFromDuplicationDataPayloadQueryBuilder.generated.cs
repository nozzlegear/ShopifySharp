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
    public sealed class CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodCreateFromDuplicationDataPayload, CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder Self => this;

        public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder() : this("customerPaymentMethodCreateFromDuplicationDataPayload")
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodCreateFromDuplicationDataPayload>(name))
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder(IQuery<CustomerPaymentMethodCreateFromDuplicationDataPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodCreateFromDuplicationDataUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodCreateFromDuplicationDataUserError>(query);
            return this;
        }
    }
}