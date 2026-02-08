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
    public sealed class SellingPlanQueryBuilder : FieldsQueryBuilderBase<SellingPlan, SellingPlanQueryBuilder>
    {
        protected override SellingPlanQueryBuilder Self => this;

        public SellingPlanQueryBuilder() : this("sellingPlan")
        {
        }

        public SellingPlanQueryBuilder(string name) : base(new Query<SellingPlan>(name))
        {
        }

        public SellingPlanQueryBuilder(IQuery<SellingPlan> query) : base(query)
        {
        }

        public SellingPlanQueryBuilder Category()
        {
            base.InnerQuery.AddField("category");
            return this;
        }

        public SellingPlanQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SellingPlanQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SellingPlanQueryBuilder InventoryPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanInventoryPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanInventoryPolicy>("inventoryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanInventoryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanInventoryPolicy>(query);
            return this;
        }

        public SellingPlanQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public SellingPlanQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public SellingPlanQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public SellingPlanQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SellingPlanQueryBuilder Options()
        {
            base.InnerQuery.AddField("options");
            return this;
        }

        public SellingPlanQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public SellingPlanQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public SellingPlanQueryBuilder BillingPolicy(Action<SellingPlanBillingPolicyUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanBillingPolicy>("billingPolicy");
            var unionBuilder = new SellingPlanBillingPolicyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public SellingPlanQueryBuilder DeliveryPolicy(Action<SellingPlanDeliveryPolicyUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanDeliveryPolicy>("deliveryPolicy");
            var unionBuilder = new SellingPlanDeliveryPolicyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public SellingPlanQueryBuilder PricingPolicies(Action<SellingPlanPricingPolicyUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicy>("pricingPolicies");
            var unionBuilder = new SellingPlanPricingPolicyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}