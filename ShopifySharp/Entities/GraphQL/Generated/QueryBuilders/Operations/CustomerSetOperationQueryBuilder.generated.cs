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

        public CustomerSetOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSetOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSetUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSetUserError>(query);
            return this;
        }
    }
}