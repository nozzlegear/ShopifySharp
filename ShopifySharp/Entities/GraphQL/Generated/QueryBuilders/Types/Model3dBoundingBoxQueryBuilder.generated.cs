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

        public Model3dBoundingBoxQueryBuilder Size(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Vector3QueryBuilder> build)
        {
            var query = new Query<Vector3>("size");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Vector3QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Vector3>(query);
            return this;
        }
    }
}