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
    public sealed class CustomerUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerUpdatePayload, CustomerUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerUpdateOperationQueryBuilder Self => this;

        public CustomerUpdateOperationQueryBuilder() : this("customerUpdate")
        {
        }

        public CustomerUpdateOperationQueryBuilder(string name) : base(new Query<CustomerUpdatePayload>(name))
        {
            Arguments = new CustomerUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerUpdateOperationQueryBuilder(IQuery<CustomerUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerUpdateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}