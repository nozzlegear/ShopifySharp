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
    public sealed class SegmentOperationQueryBuilder : FieldsQueryBuilderBase<Segment, SegmentOperationQueryBuilder>, IGraphOperationQueryBuilder<Segment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SegmentArgumentsBuilder Arguments { get; }
        protected override SegmentOperationQueryBuilder Self => this;

        public SegmentOperationQueryBuilder() : this("segment")
        {
        }

        public SegmentOperationQueryBuilder(string name) : base(new Query<Segment>(name))
        {
            Arguments = new SegmentArgumentsBuilder(base.InnerQuery);
        }

        public SegmentOperationQueryBuilder(IQuery<Segment> query) : base(query)
        {
            Arguments = new SegmentArgumentsBuilder(base.InnerQuery);
        }

        public SegmentOperationQueryBuilder CreationDate()
        {
            base.InnerQuery.AddField("creationDate");
            return this;
        }

        public SegmentOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SegmentOperationQueryBuilder LastEditDate()
        {
            base.InnerQuery.AddField("lastEditDate");
            return this;
        }

        public SegmentOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SegmentOperationQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }
    }
}