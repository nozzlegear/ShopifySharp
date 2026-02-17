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
    public sealed class Model3dBoundingBoxQueryBuilder : FieldsQueryBuilderBase<Model3dBoundingBox, Model3dBoundingBoxQueryBuilder>
    {
        protected override Model3dBoundingBoxQueryBuilder Self => this;

        public Model3dBoundingBoxQueryBuilder() : this("model3dBoundingBox")
        {
        }

        public Model3dBoundingBoxQueryBuilder(string name) : base(new Query<Model3dBoundingBox>(name))
        {
        }

        public Model3dBoundingBoxQueryBuilder(IQuery<Model3dBoundingBox> query) : base(query)
        {
        }

        public Model3dBoundingBoxQueryBuilder Size(Action<ShopifySharp.GraphQL.QueryBuilders.Types.Vector3QueryBuilder> build)
        {
            var query = new Query<Vector3>("size");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.Vector3QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Vector3>(query);
            return this;
        }
    }
}