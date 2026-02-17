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
    public sealed class OrderEditSessionOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditSession, OrderEditSessionOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditSession>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public OrderEditSessionArgumentsBuilder Arguments { get; }
        protected override OrderEditSessionOperationQueryBuilder Self => this;

        public OrderEditSessionOperationQueryBuilder() : this("orderEditSession")
        {
        }

        public OrderEditSessionOperationQueryBuilder(string name) : base(new Query<OrderEditSession>(name))
        {
            Arguments = new OrderEditSessionArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditSessionOperationQueryBuilder(IQuery<OrderEditSession> query) : base(query)
        {
            Arguments = new OrderEditSessionArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditSessionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}