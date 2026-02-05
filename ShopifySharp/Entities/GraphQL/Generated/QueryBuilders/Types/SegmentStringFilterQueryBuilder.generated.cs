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
    public sealed class SegmentStringFilterQueryBuilder : FieldsQueryBuilderBase<SegmentStringFilter, SegmentStringFilterQueryBuilder>
    {
        protected override SegmentStringFilterQueryBuilder Self => this;

        public SegmentStringFilterQueryBuilder() : this("segmentStringFilter")
        {
        }

        public SegmentStringFilterQueryBuilder(string name) : base(new Query<SegmentStringFilter>(name))
        {
        }

        public SegmentStringFilterQueryBuilder(IQuery<SegmentStringFilter> query) : base(query)
        {
        }

        public SegmentStringFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentStringFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentStringFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}