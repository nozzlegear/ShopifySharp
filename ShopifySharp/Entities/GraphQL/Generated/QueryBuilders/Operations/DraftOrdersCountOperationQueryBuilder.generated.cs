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
    public sealed class DraftOrdersCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, DraftOrdersCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DraftOrdersCountArgumentsBuilder Arguments { get; }
        protected override DraftOrdersCountOperationQueryBuilder Self => this;

        public DraftOrdersCountOperationQueryBuilder() : this("draftOrdersCount")
        {
        }

        public DraftOrdersCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new DraftOrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrdersCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new DraftOrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrdersCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public DraftOrdersCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}