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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class SegmentQueryBuilder : FieldsQueryBuilderBase<Segment, SegmentQueryBuilder>
    {
        protected override SegmentQueryBuilder Self => this;

        public SegmentQueryBuilder() : this("segment")
        {
        }

        public SegmentQueryBuilder(string name) : base(new Query<Segment>(name))
        {
        }

        public SegmentQueryBuilder(IQuery<Segment> query) : base(query)
        {
        }

        public SegmentQueryBuilder CreationDate()
        {
            base.InnerQuery.AddField("creationDate");
            return this;
        }

        public SegmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SegmentQueryBuilder LastEditDate()
        {
            base.InnerQuery.AddField("lastEditDate");
            return this;
        }

        public SegmentQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SegmentQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }
    }
}