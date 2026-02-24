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
    public sealed class MetafieldReferencerContextualPricingQueryBuilder : FieldsQueryBuilderBase<ProductVariantContextualPricing, MetafieldReferencerContextualPricingQueryBuilder>, IHasArguments<MetafieldReferencerContextualPricingArgumentsBuilder>
    {
        public MetafieldReferencerContextualPricingArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerContextualPricingQueryBuilder Self => this;

        public MetafieldReferencerContextualPricingQueryBuilder(string name) : base(new Query<ProductVariantContextualPricing>(name))
        {
            Arguments = new MetafieldReferencerContextualPricingArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerContextualPricingQueryBuilder(IQuery<ProductVariantContextualPricing> query) : base(query)
        {
            Arguments = new MetafieldReferencerContextualPricingArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerContextualPricingQueryBuilder SetArguments(Action<MetafieldReferencerContextualPricingArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerContextualPricingQueryBuilder CompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("compareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MetafieldReferencerContextualPricingQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MetafieldReferencerContextualPricingQueryBuilder QuantityPriceBreaks(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreakConnection>("quantityPriceBreaks");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreakConnection>(query);
            return this;
        }

        public MetafieldReferencerContextualPricingQueryBuilder QuantityRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("quantityRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }

        public MetafieldReferencerContextualPricingQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}