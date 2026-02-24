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
    public sealed class DiscountProductsProductsQueryBuilder : FieldsQueryBuilderBase<ProductConnection, DiscountProductsProductsQueryBuilder>, IHasArguments<DiscountProductsProductsArgumentsBuilder>
    {
        public DiscountProductsProductsArgumentsBuilder Arguments { get; }
        protected override DiscountProductsProductsQueryBuilder Self => this;

        public DiscountProductsProductsQueryBuilder(string name) : base(new Query<ProductConnection>(name))
        {
            Arguments = new DiscountProductsProductsArgumentsBuilder(base.InnerQuery);
        }

        public DiscountProductsProductsQueryBuilder(IQuery<ProductConnection> query) : base(query)
        {
            Arguments = new DiscountProductsProductsArgumentsBuilder(base.InnerQuery);
        }

        public DiscountProductsProductsQueryBuilder SetArguments(Action<DiscountProductsProductsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountProductsProductsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductEdgeQueryBuilder> build)
        {
            var query = new Query<ProductEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductEdge>(query);
            return this;
        }

        public DiscountProductsProductsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public DiscountProductsProductsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}