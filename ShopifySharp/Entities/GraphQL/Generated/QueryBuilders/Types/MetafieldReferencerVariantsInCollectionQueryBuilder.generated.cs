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
    public sealed class MetafieldReferencerVariantsInCollectionQueryBuilder : FieldsQueryBuilderBase<ProductVariantConnection, MetafieldReferencerVariantsInCollectionQueryBuilder>, IHasArguments<MetafieldReferencerVariantsInCollectionArgumentsBuilder>
    {
        public MetafieldReferencerVariantsInCollectionArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerVariantsInCollectionQueryBuilder Self => this;

        public MetafieldReferencerVariantsInCollectionQueryBuilder(string name) : base(new Query<ProductVariantConnection>(name))
        {
            Arguments = new MetafieldReferencerVariantsInCollectionArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerVariantsInCollectionQueryBuilder(IQuery<ProductVariantConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerVariantsInCollectionArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerVariantsInCollectionQueryBuilder SetArguments(Action<MetafieldReferencerVariantsInCollectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantEdge>(query);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}