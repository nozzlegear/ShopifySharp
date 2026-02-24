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
    public sealed class MetafieldReferencerProductImagesQueryBuilder : FieldsQueryBuilderBase<ImageConnection, MetafieldReferencerProductImagesQueryBuilder>, IHasArguments<MetafieldReferencerProductImagesArgumentsBuilder>
    {
        public MetafieldReferencerProductImagesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerProductImagesQueryBuilder Self => this;

        public MetafieldReferencerProductImagesQueryBuilder(string name) : base(new Query<ImageConnection>(name))
        {
            Arguments = new MetafieldReferencerProductImagesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerProductImagesQueryBuilder(IQuery<ImageConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerProductImagesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerProductImagesQueryBuilder SetArguments(Action<MetafieldReferencerProductImagesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerProductImagesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageEdgeQueryBuilder> build)
        {
            var query = new Query<ImageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageEdge>(query);
            return this;
        }

        public MetafieldReferencerProductImagesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public MetafieldReferencerProductImagesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}