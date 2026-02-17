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

        public ImageEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }
    }
}