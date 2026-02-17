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

        public CustomerPaymentMethodGetDuplicationDataOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodGetDuplicationDataUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodGetDuplicationDataUserError>(query);
            return this;
        }
    }
}