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

        public CustomerUpdateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}