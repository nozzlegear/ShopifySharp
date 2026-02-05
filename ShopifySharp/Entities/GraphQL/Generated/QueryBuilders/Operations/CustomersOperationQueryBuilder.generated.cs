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
    public sealed class CustomersOperationQueryBuilder : FieldsQueryBuilderBase<CustomerConnection, CustomersOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomersArgumentsBuilder Arguments { get; }
        protected override CustomersOperationQueryBuilder Self => this;

        public CustomersOperationQueryBuilder() : this("customers")
        {
        }

        public CustomersOperationQueryBuilder(string name) : base(new Query<CustomerConnection>(name))
        {
            Arguments = new CustomersArgumentsBuilder(base.InnerQuery);
        }

        public CustomersOperationQueryBuilder(IQuery<CustomerConnection> query) : base(query)
        {
            Arguments = new CustomersArgumentsBuilder(base.InnerQuery);
        }

        public CustomersOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEdge>(query);
            return this;
        }

        public CustomersOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomersOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}