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
    public sealed class CustomerCancelDataErasureOperationQueryBuilder : FieldsQueryBuilderBase<CustomerCancelDataErasurePayload, CustomerCancelDataErasureOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerCancelDataErasurePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerCancelDataErasureArgumentsBuilder Arguments { get; }
        protected override CustomerCancelDataErasureOperationQueryBuilder Self => this;

        public CustomerCancelDataErasureOperationQueryBuilder() : this("customerCancelDataErasure")
        {
        }

        public CustomerCancelDataErasureOperationQueryBuilder(string name) : base(new Query<CustomerCancelDataErasurePayload>(name))
        {
            Arguments = new CustomerCancelDataErasureArgumentsBuilder(base.InnerQuery);
        }

        public CustomerCancelDataErasureOperationQueryBuilder(IQuery<CustomerCancelDataErasurePayload> query) : base(query)
        {
            Arguments = new CustomerCancelDataErasureArgumentsBuilder(base.InnerQuery);
        }

        public CustomerCancelDataErasureOperationQueryBuilder CustomerId()
        {
            base.InnerQuery.AddField("customerId");
            return this;
        }

        public CustomerCancelDataErasureOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCancelDataErasureUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerCancelDataErasureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCancelDataErasureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerCancelDataErasureUserError>(query);
            return this;
        }
    }
}