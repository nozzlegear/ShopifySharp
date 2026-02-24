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
    public sealed class ProductBundleComponentsQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentConnection, ProductBundleComponentsQueryBuilder>, IHasArguments<ProductBundleComponentsArgumentsBuilder>
    {
        public ProductBundleComponentsArgumentsBuilder Arguments { get; }
        protected override ProductBundleComponentsQueryBuilder Self => this;

        public ProductBundleComponentsQueryBuilder(string name) : base(new Query<ProductBundleComponentConnection>(name))
        {
            Arguments = new ProductBundleComponentsArgumentsBuilder(base.InnerQuery);
        }

        public ProductBundleComponentsQueryBuilder(IQuery<ProductBundleComponentConnection> query) : base(query)
        {
            Arguments = new ProductBundleComponentsArgumentsBuilder(base.InnerQuery);
        }

        public ProductBundleComponentsQueryBuilder SetArguments(Action<ProductBundleComponentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductBundleComponentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentEdgeQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentEdge>(query);
            return this;
        }

        public ProductBundleComponentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponent>(query);
            return this;
        }

        public ProductBundleComponentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}