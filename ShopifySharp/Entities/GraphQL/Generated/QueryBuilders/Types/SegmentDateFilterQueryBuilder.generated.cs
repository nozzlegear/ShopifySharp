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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SegmentDateFilterQueryBuilder : FieldsQueryBuilderBase<SegmentDateFilter, SegmentDateFilterQueryBuilder>
    {
        protected override SegmentDateFilterQueryBuilder Self => this;

        public SegmentDateFilterQueryBuilder() : this("segmentDateFilter")
        {
        }

        public SegmentDateFilterQueryBuilder(string name) : base(new Query<SegmentDateFilter>(name))
        {
        }

        public SegmentDateFilterQueryBuilder(IQuery<SegmentDateFilter> query) : base(query)
        {
        }

        public SegmentDateFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentDateFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentDateFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}