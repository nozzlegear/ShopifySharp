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
    public sealed class CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodGetDuplicationDataPayload, CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodGetDuplicationDataPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodGetDuplicationDataArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder Self => this;

        public CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder() : this("customerPaymentMethodGetDuplicationData")
        {
        }

        public CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodGetDuplicationDataPayload>(name))
        {
            Arguments = new CustomerPaymentMethodGetDuplicationDataArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder(IQuery<CustomerPaymentMethodGetDuplicationDataPayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodGetDuplicationDataArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder EncryptedDuplicationData()
        {
            base.InnerQuery.AddField("encryptedDuplicationData");
            return this;
        }

        public CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodGetDuplicationDataUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodGetDuplicationDataUserError>(query);
            return this;
        }
    }
}