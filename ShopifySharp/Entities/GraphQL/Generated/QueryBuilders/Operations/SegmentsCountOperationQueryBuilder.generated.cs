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
    public sealed class SegmentsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, SegmentsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SegmentsCountArgumentsBuilder Arguments { get; }
        protected override SegmentsCountOperationQueryBuilder Self => this;

        public SegmentsCountOperationQueryBuilder() : this("segmentsCount")
        {
        }

        public SegmentsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new SegmentsCountArgumentsBuilder(base.InnerQuery);
        }

        public SegmentsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new SegmentsCountArgumentsBuilder(base.InnerQuery);
        }

        public SegmentsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public SegmentsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}