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
    public sealed class ProductComponentTypeNonComponentVariantsQueryBuilder : FieldsQueryBuilderBase<ProductVariantConnection, ProductComponentTypeNonComponentVariantsQueryBuilder>, IHasArguments<ProductComponentTypeNonComponentVariantsArgumentsBuilder>
    {
        public ProductComponentTypeNonComponentVariantsArgumentsBuilder Arguments { get; }
        protected override ProductComponentTypeNonComponentVariantsQueryBuilder Self => this;

        public ProductComponentTypeNonComponentVariantsQueryBuilder(string name) : base(new Query<ProductVariantConnection>(name))
        {
            Arguments = new ProductComponentTypeNonComponentVariantsArgumentsBuilder(base.InnerQuery);
        }

        public ProductComponentTypeNonComponentVariantsQueryBuilder(IQuery<ProductVariantConnection> query) : base(query)
        {
            Arguments = new ProductComponentTypeNonComponentVariantsArgumentsBuilder(base.InnerQuery);
        }

        public ProductComponentTypeNonComponentVariantsQueryBuilder SetArguments(Action<ProductComponentTypeNonComponentVariantsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductComponentTypeNonComponentVariantsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantEdge>(query);
            return this;
        }

        public ProductComponentTypeNonComponentVariantsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductComponentTypeNonComponentVariantsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}