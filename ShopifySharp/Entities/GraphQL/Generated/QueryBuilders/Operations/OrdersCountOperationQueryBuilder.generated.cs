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
    public sealed class OrdersCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, OrdersCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public OrdersCountArgumentsBuilder Arguments { get; }
        protected override OrdersCountOperationQueryBuilder Self => this;

        public OrdersCountOperationQueryBuilder() : this("ordersCount")
        {
        }

        public OrdersCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new OrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public OrdersCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new OrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public OrdersCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public OrdersCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}