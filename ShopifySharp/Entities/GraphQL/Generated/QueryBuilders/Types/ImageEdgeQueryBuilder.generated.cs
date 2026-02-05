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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ImageEdgeQueryBuilder : FieldsQueryBuilderBase<ImageEdge, ImageEdgeQueryBuilder>
    {
        protected override ImageEdgeQueryBuilder Self => this;

        public ImageEdgeQueryBuilder() : this("imageEdge")
        {
        }

        public ImageEdgeQueryBuilder(string name) : base(new Query<ImageEdge>(name))
        {
        }

        public ImageEdgeQueryBuilder(IQuery<ImageEdge> query) : base(query)
        {
        }

        public ImageEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ImageEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }
    }
}