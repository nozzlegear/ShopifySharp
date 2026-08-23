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
    public sealed class SegmentFloatFilterQueryBuilder : FieldsQueryBuilderBase<SegmentFloatFilter, SegmentFloatFilterQueryBuilder>
    {
        protected override SegmentFloatFilterQueryBuilder Self => this;

        public SegmentFloatFilterQueryBuilder() : this("segmentFloatFilter")
        {
        }

        public SegmentFloatFilterQueryBuilder(string name) : base(new Query<SegmentFloatFilter>(name))
        {
        }

        public SegmentFloatFilterQueryBuilder(IQuery<SegmentFloatFilter> query) : base(query)
        {
        }

        public SegmentFloatFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentFloatFilterQueryBuilder MaxRange()
        {
            base.InnerQuery.AddField("maxRange");
            return this;
        }

        public SegmentFloatFilterQueryBuilder MinRange()
        {
            base.InnerQuery.AddField("minRange");
            return this;
        }

        public SegmentFloatFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentFloatFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}