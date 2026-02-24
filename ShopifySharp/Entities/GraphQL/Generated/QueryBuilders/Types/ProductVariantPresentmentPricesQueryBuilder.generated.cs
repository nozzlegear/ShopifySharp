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
    public sealed class ProductVariantPresentmentPricesQueryBuilder : FieldsQueryBuilderBase<ProductVariantPricePairConnection, ProductVariantPresentmentPricesQueryBuilder>, IHasArguments<ProductVariantPresentmentPricesArgumentsBuilder>
    {
        public ProductVariantPresentmentPricesArgumentsBuilder Arguments { get; }
        protected override ProductVariantPresentmentPricesQueryBuilder Self => this;

        public ProductVariantPresentmentPricesQueryBuilder(string name) : base(new Query<ProductVariantPricePairConnection>(name))
        {
            Arguments = new ProductVariantPresentmentPricesArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantPresentmentPricesQueryBuilder(IQuery<ProductVariantPricePairConnection> query) : base(query)
        {
            Arguments = new ProductVariantPresentmentPricesArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantPresentmentPricesQueryBuilder SetArguments(Action<ProductVariantPresentmentPricesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductVariantPresentmentPricesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairEdge>(query);
            return this;
        }

        public ProductVariantPresentmentPricesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePair>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePair>(query);
            return this;
        }

        public ProductVariantPresentmentPricesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}