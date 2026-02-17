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
    public sealed class SellingPlanInventoryPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanInventoryPolicy, SellingPlanInventoryPolicyQueryBuilder>
    {
        protected override SellingPlanInventoryPolicyQueryBuilder Self => this;

        public SellingPlanInventoryPolicyQueryBuilder() : this("sellingPlanInventoryPolicy")
        {
        }

        public SellingPlanInventoryPolicyQueryBuilder(string name) : base(new Query<SellingPlanInventoryPolicy>(name))
        {
        }

        public SellingPlanInventoryPolicyQueryBuilder(IQuery<SellingPlanInventoryPolicy> query) : base(query)
        {
        }

        public SellingPlanInventoryPolicyQueryBuilder Reserve()
        {
            base.InnerQuery.AddField("reserve");
            return this;
        }
    }
}