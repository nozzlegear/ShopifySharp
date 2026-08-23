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
    public sealed class SegmentAssociationFilterQueryBuilder : FieldsQueryBuilderBase<SegmentAssociationFilter, SegmentAssociationFilterQueryBuilder>
    {
        protected override SegmentAssociationFilterQueryBuilder Self => this;

        public SegmentAssociationFilterQueryBuilder() : this("segmentAssociationFilter")
        {
        }

        public SegmentAssociationFilterQueryBuilder(string name) : base(new Query<SegmentAssociationFilter>(name))
        {
        }

        public SegmentAssociationFilterQueryBuilder(IQuery<SegmentAssociationFilter> query) : base(query)
        {
        }

        public SegmentAssociationFilterQueryBuilder LocalizedName()
        {
            base.InnerQuery.AddField("localizedName");
            return this;
        }

        public SegmentAssociationFilterQueryBuilder MultiValue()
        {
            base.InnerQuery.AddField("multiValue");
            return this;
        }

        public SegmentAssociationFilterQueryBuilder QueryName_()
        {
            base.InnerQuery.AddField("queryName");
            return this;
        }
    }
}