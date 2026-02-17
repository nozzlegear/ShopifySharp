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
    public sealed class CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodGetUpdateUrlPayload, CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerPaymentMethodGetUpdateUrlPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerPaymentMethodGetUpdateUrlArgumentsBuilder Arguments { get; }
        protected override CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder Self => this;

        public CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder() : this("customerPaymentMethodGetUpdateUrl")
        {
        }

        public CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder(string name) : base(new Query<CustomerPaymentMethodGetUpdateUrlPayload>(name))
        {
            Arguments = new CustomerPaymentMethodGetUpdateUrlArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder(IQuery<CustomerPaymentMethodGetUpdateUrlPayload> query) : base(query)
        {
            Arguments = new CustomerPaymentMethodGetUpdateUrlArgumentsBuilder(base.InnerQuery);
        }

        public CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder UpdatePaymentMethodUrl()
        {
            base.InnerQuery.AddField("updatePaymentMethodUrl");
            return this;
        }

        public CustomerPaymentMethodGetUpdateUrlOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodGetUpdateUrlUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodGetUpdateUrlUserError>(query);
            return this;
        }
    }
}