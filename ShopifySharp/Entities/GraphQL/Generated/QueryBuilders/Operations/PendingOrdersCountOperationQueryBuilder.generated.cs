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
    public sealed class PendingOrdersCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, PendingOrdersCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override PendingOrdersCountOperationQueryBuilder Self => this;

        public PendingOrdersCountOperationQueryBuilder() : this("pendingOrdersCount")
        {
        }

        public PendingOrdersCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
        }

        public PendingOrdersCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
        }

        public PendingOrdersCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public PendingOrdersCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}