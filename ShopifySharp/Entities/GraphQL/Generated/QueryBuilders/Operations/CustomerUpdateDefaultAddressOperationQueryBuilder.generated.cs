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
    public sealed class CustomerUpdateDefaultAddressOperationQueryBuilder : FieldsQueryBuilderBase<CustomerUpdateDefaultAddressPayload, CustomerUpdateDefaultAddressOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerUpdateDefaultAddressPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerUpdateDefaultAddressArgumentsBuilder Arguments { get; }
        protected override CustomerUpdateDefaultAddressOperationQueryBuilder Self => this;

        public CustomerUpdateDefaultAddressOperationQueryBuilder() : this("customerUpdateDefaultAddress")
        {
        }

        public CustomerUpdateDefaultAddressOperationQueryBuilder(string name) : base(new Query<CustomerUpdateDefaultAddressPayload>(name))
        {
            Arguments = new CustomerUpdateDefaultAddressArgumentsBuilder(base.InnerQuery);
        }

        public CustomerUpdateDefaultAddressOperationQueryBuilder(IQuery<CustomerUpdateDefaultAddressPayload> query) : base(query)
        {
            Arguments = new CustomerUpdateDefaultAddressArgumentsBuilder(base.InnerQuery);
        }

        public CustomerUpdateDefaultAddressOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerUpdateDefaultAddressOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}