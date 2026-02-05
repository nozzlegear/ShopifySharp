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
    public sealed class DiscountNodesCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, DiscountNodesCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DiscountNodesCountArgumentsBuilder Arguments { get; }
        protected override DiscountNodesCountOperationQueryBuilder Self => this;

        public DiscountNodesCountOperationQueryBuilder() : this("discountNodesCount")
        {
        }

        public DiscountNodesCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new DiscountNodesCountArgumentsBuilder(base.InnerQuery);
        }

        public DiscountNodesCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new DiscountNodesCountArgumentsBuilder(base.InnerQuery);
        }

        public DiscountNodesCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public DiscountNodesCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}