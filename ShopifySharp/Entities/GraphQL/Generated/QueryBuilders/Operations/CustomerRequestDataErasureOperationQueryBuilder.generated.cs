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
    public sealed class CustomerRequestDataErasureOperationQueryBuilder : FieldsQueryBuilderBase<CustomerRequestDataErasurePayload, CustomerRequestDataErasureOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerRequestDataErasurePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerRequestDataErasureArgumentsBuilder Arguments { get; }
        protected override CustomerRequestDataErasureOperationQueryBuilder Self => this;

        public CustomerRequestDataErasureOperationQueryBuilder() : this("customerRequestDataErasure")
        {
        }

        public CustomerRequestDataErasureOperationQueryBuilder(string name) : base(new Query<CustomerRequestDataErasurePayload>(name))
        {
            Arguments = new CustomerRequestDataErasureArgumentsBuilder(base.InnerQuery);
        }

        public CustomerRequestDataErasureOperationQueryBuilder(IQuery<CustomerRequestDataErasurePayload> query) : base(query)
        {
            Arguments = new CustomerRequestDataErasureArgumentsBuilder(base.InnerQuery);
        }

        public CustomerRequestDataErasureOperationQueryBuilder CustomerId()
        {
            base.InnerQuery.AddField("customerId");
            return this;
        }

        public CustomerRequestDataErasureOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerRequestDataErasureUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerRequestDataErasureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerRequestDataErasureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerRequestDataErasureUserError>(query);
            return this;
        }
    }
}