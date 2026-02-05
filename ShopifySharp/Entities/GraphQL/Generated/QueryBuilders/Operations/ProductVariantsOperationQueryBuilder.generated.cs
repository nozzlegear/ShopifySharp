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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ProductVariantsOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantConnection, ProductVariantsOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductVariantsArgumentsBuilder Arguments { get; }
        protected override ProductVariantsOperationQueryBuilder Self => this;

        public ProductVariantsOperationQueryBuilder() : this("productVariants")
        {
        }

        public ProductVariantsOperationQueryBuilder(string name) : base(new Query<ProductVariantConnection>(name))
        {
            Arguments = new ProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsOperationQueryBuilder(IQuery<ProductVariantConnection> query) : base(query)
        {
            Arguments = new ProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantEdge>(query);
            return this;
        }

        public ProductVariantsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}