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
    public sealed class ReturnableFulfillmentsOperationQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentConnection, ReturnableFulfillmentsOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnableFulfillmentConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReturnableFulfillmentsArgumentsBuilder Arguments { get; }
        protected override ReturnableFulfillmentsOperationQueryBuilder Self => this;

        public ReturnableFulfillmentsOperationQueryBuilder() : this("returnableFulfillments")
        {
        }

        public ReturnableFulfillmentsOperationQueryBuilder(string name) : base(new Query<ReturnableFulfillmentConnection>(name))
        {
            Arguments = new ReturnableFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnableFulfillmentsOperationQueryBuilder(IQuery<ReturnableFulfillmentConnection> query) : base(query)
        {
            Arguments = new ReturnableFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnableFulfillmentsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentEdge>(query);
            return this;
        }

        public ReturnableFulfillmentsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillment>(query);
            return this;
        }

        public ReturnableFulfillmentsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}