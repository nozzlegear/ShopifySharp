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
    public sealed class SegmentEventFilterParameterQueryBuilder : FieldsQueryBuilderBase<SegmentEventFilterParameter, SegmentEventFilterParameterQueryBuilder>
    {
        protected override SegmentEventFilterParameterQueryBuilder Self => this;

        public SegmentEventFilterParameterQueryBuilder() : this("segmentEventFilterParameter")
        {
        }

        public SegmentEventFilterParameterQueryBuilder(string name) : base(new Query<SegmentEventFilterParameter>(name))
        {
        }

        public SegmentEventFilterParameterQueryBuilder(IQuery<SegmentEventFilterParameter> query) : base(query)
        {
        }

        public SegmentEventFilterParameterQueryBuilder AcceptsMultipleValues()
        {
            base.InnerQuery.AddField("acceptsMultipleValues");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder LocalizedDescription()
        {
            base.InnerQuery.AddField("localizedDescription");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder MaxRange()
        {
            base.InnerQuery.AddField("maxRange");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder MinRange()
        {
            base.InnerQuery.AddField("minRange");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder Optional()
        {
            base.InnerQuery.AddField("optional");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder ParameterType()
        {
            base.InnerQuery.AddField("parameterType");
            return this;
        }

        public SegmentEventFilterParameterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}