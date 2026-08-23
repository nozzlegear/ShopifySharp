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
    public sealed class SegmentBooleanFilterQueryBuilder : FieldsQueryBuilderBase<SegmentBooleanFilter, SegmentBooleanFilterQueryBuilder>
    {
        protected override SegmentBooleanFilterQueryBuilder Self => this;

        public SegmentBooleanFilterQueryBuilder() : this("segmentBooleanFilter")
        {
        }

        public SegmentBooleanFilterQueryBuilder(string name) : base(new Query<SegmentBooleanFilter>(name))
        {
        }

        public SegmentBooleanFilterQueryBuilder(IQuery<SegmentBooleanFilter> query) : base(query)
        {
        }

        public SegmentBooleanFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentBooleanFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentBooleanFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}