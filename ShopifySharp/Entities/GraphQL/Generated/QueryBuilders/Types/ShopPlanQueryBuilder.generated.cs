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
    public sealed class ShopPlanQueryBuilder : FieldsQueryBuilderBase<ShopPlan, ShopPlanQueryBuilder>
    {
        protected override ShopPlanQueryBuilder Self => this;

        public ShopPlanQueryBuilder() : this("shopPlan")
        {
        }

        public ShopPlanQueryBuilder(string name) : base(new Query<ShopPlan>(name))
        {
        }

        public ShopPlanQueryBuilder(IQuery<ShopPlan> query) : base(query)
        {
        }

        [Obsolete("Use `publicDisplayName` instead.")]
        public ShopPlanQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public ShopPlanQueryBuilder PartnerDevelopment()
        {
            base.InnerQuery.AddField("partnerDevelopment");
            return this;
        }

        public ShopPlanQueryBuilder PublicDisplayName()
        {
            base.InnerQuery.AddField("publicDisplayName");
            return this;
        }

        public ShopPlanQueryBuilder ShopifyPlus()
        {
            base.InnerQuery.AddField("shopifyPlus");
            return this;
        }
    }
}