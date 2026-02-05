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
    public sealed class SegmentIntegerFilterQueryBuilder : FieldsQueryBuilderBase<SegmentIntegerFilter, SegmentIntegerFilterQueryBuilder>
    {
        protected override SegmentIntegerFilterQueryBuilder Self => this;

        public SegmentIntegerFilterQueryBuilder() : this("segmentIntegerFilter")
        {
        }

        public SegmentIntegerFilterQueryBuilder(string name) : base(new Query<SegmentIntegerFilter>(name))
        {
        }

        public SegmentIntegerFilterQueryBuilder(IQuery<SegmentIntegerFilter> query) : base(query)
        {
        }

        public SegmentIntegerFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentIntegerFilterQueryBuilder MaxRange()
        {
            base.InnerQuery.AddField("maxRange");
            return this;
        }

        public SegmentIntegerFilterQueryBuilder MinRange()
        {
            base.InnerQuery.AddField("minRange");
            return this;
        }

        public SegmentIntegerFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentIntegerFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}