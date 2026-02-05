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
    public sealed class SegmentEnumFilterQueryBuilder : FieldsQueryBuilderBase<SegmentEnumFilter, SegmentEnumFilterQueryBuilder>
    {
        protected override SegmentEnumFilterQueryBuilder Self => this;

        public SegmentEnumFilterQueryBuilder() : this("segmentEnumFilter")
        {
        }

        public SegmentEnumFilterQueryBuilder(string name) : base(new Query<SegmentEnumFilter>(name))
        {
        }

        public SegmentEnumFilterQueryBuilder(IQuery<SegmentEnumFilter> query) : base(query)
        {
        }

        public SegmentEnumFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentEnumFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentEnumFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}