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
    public sealed class SegmentValueQueryBuilder : FieldsQueryBuilderBase<SegmentValue, SegmentValueQueryBuilder>
    {
        protected override SegmentValueQueryBuilder Self => this;

        public SegmentValueQueryBuilder() : this("segmentValue")
        {
        }

        public SegmentValueQueryBuilder(string name) : base(new Query<SegmentValue>(name))
        {
        }

        public SegmentValueQueryBuilder(IQuery<SegmentValue> query) : base(query)
        {
        }

        public SegmentValueQueryBuilder LocalizedValue()
        {
            base.InnerQuery.AddField("localizedValue");
            return this;
        }

        public SegmentValueQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}