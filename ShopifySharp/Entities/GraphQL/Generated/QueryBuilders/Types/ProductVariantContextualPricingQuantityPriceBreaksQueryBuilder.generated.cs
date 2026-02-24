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
    public sealed class ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder : FieldsQueryBuilderBase<QuantityPriceBreakConnection, ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder>, IHasArguments<ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder>
    {
        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder Arguments { get; }
        protected override ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder Self => this;

        public ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder(string name) : base(new Query<QuantityPriceBreakConnection>(name))
        {
            Arguments = new ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder(IQuery<QuantityPriceBreakConnection> query) : base(query)
        {
            Arguments = new ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder SetArguments(Action<ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakEdgeQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreakEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreakEdge>(query);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreak>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreak>(query);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}