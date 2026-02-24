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
    public sealed class MetafieldReferencerPresentmentPricesQueryBuilder : FieldsQueryBuilderBase<ProductVariantPricePairConnection, MetafieldReferencerPresentmentPricesQueryBuilder>, IHasArguments<MetafieldReferencerPresentmentPricesArgumentsBuilder>
    {
        public MetafieldReferencerPresentmentPricesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerPresentmentPricesQueryBuilder Self => this;

        public MetafieldReferencerPresentmentPricesQueryBuilder(string name) : base(new Query<ProductVariantPricePairConnection>(name))
        {
            Arguments = new MetafieldReferencerPresentmentPricesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerPresentmentPricesQueryBuilder(IQuery<ProductVariantPricePairConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerPresentmentPricesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerPresentmentPricesQueryBuilder SetArguments(Action<MetafieldReferencerPresentmentPricesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerPresentmentPricesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairEdge>(query);
            return this;
        }

        public MetafieldReferencerPresentmentPricesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePair>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePair>(query);
            return this;
        }

        public MetafieldReferencerPresentmentPricesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}