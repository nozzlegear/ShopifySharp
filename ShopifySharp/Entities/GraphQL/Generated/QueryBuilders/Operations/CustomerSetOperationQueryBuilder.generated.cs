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
    public sealed class CustomerSetOperationQueryBuilder : FieldsQueryBuilderBase<CustomerSetPayload, CustomerSetOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerSetPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerSetArgumentsBuilder Arguments { get; }
        protected override CustomerSetOperationQueryBuilder Self => this;

        public CustomerSetOperationQueryBuilder() : this("customerSet")
        {
        }

        public CustomerSetOperationQueryBuilder(string name) : base(new Query<CustomerSetPayload>(name))
        {
            Arguments = new CustomerSetArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSetOperationQueryBuilder(IQuery<CustomerSetPayload> query) : base(query)
        {
            Arguments = new CustomerSetArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSetOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSetOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSetUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSetUserError>(query);
            return this;
        }
    }
}