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
    public sealed class SegmentFilterQueryBuilder : FieldsQueryBuilderBase<ISegmentFilter, SegmentFilterQueryBuilder>
    {
        protected override SegmentFilterQueryBuilder Self => this;

        public SegmentFilterQueryBuilder() : this("segmentFilter")
        {
        }

        public SegmentFilterQueryBuilder(string name) : base(new Query<ISegmentFilter>(name))
        {
        }

        public SegmentFilterQueryBuilder(IQuery<ISegmentFilter> query) : base(query)
        {
        }

        public SegmentFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}