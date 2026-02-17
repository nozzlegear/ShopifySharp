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
    public sealed class DiscountCodesCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, DiscountCodesCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DiscountCodesCountArgumentsBuilder Arguments { get; }
        protected override DiscountCodesCountOperationQueryBuilder Self => this;

        public DiscountCodesCountOperationQueryBuilder() : this("discountCodesCount")
        {
        }

        public DiscountCodesCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new DiscountCodesCountArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodesCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new DiscountCodesCountArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodesCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public DiscountCodesCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}