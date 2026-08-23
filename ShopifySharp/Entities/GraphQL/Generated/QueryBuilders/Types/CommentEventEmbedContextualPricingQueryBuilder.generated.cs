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
    public sealed class CommentEventEmbedContextualPricingQueryBuilder : FieldsQueryBuilderBase<ProductVariantContextualPricing, CommentEventEmbedContextualPricingQueryBuilder>, IHasArguments<CommentEventEmbedContextualPricingArgumentsBuilder>
    {
        public CommentEventEmbedContextualPricingArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedContextualPricingQueryBuilder Self => this;

        public CommentEventEmbedContextualPricingQueryBuilder(string name) : base(new Query<ProductVariantContextualPricing>(name))
        {
            Arguments = new CommentEventEmbedContextualPricingArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedContextualPricingQueryBuilder(IQuery<ProductVariantContextualPricing> query) : base(query)
        {
            Arguments = new CommentEventEmbedContextualPricingArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedContextualPricingQueryBuilder SetArguments(Action<CommentEventEmbedContextualPricingArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedContextualPricingQueryBuilder CompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("compareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CommentEventEmbedContextualPricingQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CommentEventEmbedContextualPricingQueryBuilder QuantityPriceBreaks(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreakConnection>("quantityPriceBreaks");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreakConnection>(query);
            return this;
        }

        public CommentEventEmbedContextualPricingQueryBuilder QuantityRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("quantityRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }

        public CommentEventEmbedContextualPricingQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}