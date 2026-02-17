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

        public CustomerCreateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}