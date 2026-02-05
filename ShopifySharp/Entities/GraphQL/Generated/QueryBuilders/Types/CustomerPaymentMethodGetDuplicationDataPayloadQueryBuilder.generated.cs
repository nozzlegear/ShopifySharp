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
    public sealed class CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodGetDuplicationDataPayload, CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder Self => this;

        public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder() : this("customerPaymentMethodGetDuplicationDataPayload")
        {
        }

        public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodGetDuplicationDataPayload>(name))
        {
        }

        public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder(IQuery<CustomerPaymentMethodGetDuplicationDataPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder EncryptedDuplicationData()
        {
            base.InnerQuery.AddField("encryptedDuplicationData");
            return this;
        }

        public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodGetDuplicationDataUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodGetDuplicationDataUserError>(query);
            return this;
        }
    }
}