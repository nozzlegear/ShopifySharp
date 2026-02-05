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
    public sealed class SegmentEventFilterQueryBuilder : FieldsQueryBuilderBase<SegmentEventFilter, SegmentEventFilterQueryBuilder>
    {
        protected override SegmentEventFilterQueryBuilder Self => this;

        public SegmentEventFilterQueryBuilder() : this("segmentEventFilter")
        {
        }

        public SegmentEventFilterQueryBuilder(string name) : base(new Query<SegmentEventFilter>(name))
        {
        }

        public SegmentEventFilterQueryBuilder(IQuery<SegmentEventFilter> query) : base(query)
        {
        }

        public SegmentEventFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentEventFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentEventFilterQueryBuilder Parameters(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentEventFilterParameterQueryBuilder> build)
        {
            var query = new Query<SegmentEventFilterParameter>("parameters");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentEventFilterParameterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentEventFilterParameter>(query);
            return this;
        }

        public SegmentEventFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }

        public SegmentEventFilterQueryBuilder ReturnValueType()
        {
            base.InnerQuery.AddField("returnValueType");
            return this;
        }
    }
}