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
    public sealed class Vector3QueryBuilder : FieldsQueryBuilderBase<Vector3, Vector3QueryBuilder>
    {
        protected override Vector3QueryBuilder Self => this;

        public Vector3QueryBuilder() : this("vector3")
        {
        }

        public Vector3QueryBuilder(string name) : base(new Query<Vector3>(name))
        {
        }

        public Vector3QueryBuilder(IQuery<Vector3> query) : base(query)
        {
        }

        public Vector3QueryBuilder X()
        {
            base.InnerQuery.AddField("x");
            return this;
        }

        public Vector3QueryBuilder Y()
        {
            base.InnerQuery.AddField("y");
            return this;
        }

        public Vector3QueryBuilder Z()
        {
            base.InnerQuery.AddField("z");
            return this;
        }
    }
}