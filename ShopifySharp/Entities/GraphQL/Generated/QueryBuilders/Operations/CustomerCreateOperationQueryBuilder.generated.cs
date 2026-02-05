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
    public sealed class CustomerCreateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerCreatePayload, CustomerCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerCreateArgumentsBuilder Arguments { get; }
        protected override CustomerCreateOperationQueryBuilder Self => this;

        public CustomerCreateOperationQueryBuilder() : this("customerCreate")
        {
        }

        public CustomerCreateOperationQueryBuilder(string name) : base(new Query<CustomerCreatePayload>(name))
        {
            Arguments = new CustomerCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerCreateOperationQueryBuilder(IQuery<CustomerCreatePayload> query) : base(query)
        {
            Arguments = new CustomerCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerCreateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}