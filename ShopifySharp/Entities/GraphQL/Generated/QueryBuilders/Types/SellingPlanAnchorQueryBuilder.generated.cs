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
    public sealed class SellingPlanAnchorQueryBuilder : FieldsQueryBuilderBase<SellingPlanAnchor, SellingPlanAnchorQueryBuilder>
    {
        protected override SellingPlanAnchorQueryBuilder Self => this;

        public SellingPlanAnchorQueryBuilder() : this("sellingPlanAnchor")
        {
        }

        public SellingPlanAnchorQueryBuilder(string name) : base(new Query<SellingPlanAnchor>(name))
        {
        }

        public SellingPlanAnchorQueryBuilder(IQuery<SellingPlanAnchor> query) : base(query)
        {
        }

        public SellingPlanAnchorQueryBuilder CutoffDay()
        {
            base.InnerQuery.AddField("cutoffDay");
            return this;
        }

        public SellingPlanAnchorQueryBuilder Day()
        {
            base.InnerQuery.AddField("day");
            return this;
        }

        public SellingPlanAnchorQueryBuilder Month()
        {
            base.InnerQuery.AddField("month");
            return this;
        }

        public SellingPlanAnchorQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}