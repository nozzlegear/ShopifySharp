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

        public CustomerUpdateDefaultAddressOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerUpdateDefaultAddressOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}