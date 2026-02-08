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
    public sealed class LineItemSellingPlanQueryBuilder : FieldsQueryBuilderBase<LineItemSellingPlan, LineItemSellingPlanQueryBuilder>
    {
        protected override LineItemSellingPlanQueryBuilder Self => this;

        public LineItemSellingPlanQueryBuilder() : this("lineItemSellingPlan")
        {
        }

        public LineItemSellingPlanQueryBuilder(string name) : base(new Query<LineItemSellingPlan>(name))
        {
        }

        public LineItemSellingPlanQueryBuilder(IQuery<LineItemSellingPlan> query) : base(query)
        {
        }

        public LineItemSellingPlanQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public LineItemSellingPlanQueryBuilder SellingPlanId()
        {
            base.InnerQuery.AddField("sellingPlanId");
            return this;
        }
    }
}